#!/usr/bin/ruby

$LOAD_PATH << File.dirname(__FILE__)

require 'rubygems'
require 'fix_dictionary'
require 'fields_gen'
require 'messages_gen'
require 'proj_gen'
require 'message_factory_gen'

class Generator  
  def self.generate
    generator = Generator.new
    generator.generate_csproj
    generator.generate_message_factories
    generator.generate_fields
    generator.generate_messages
  end
  
  def initialize
    @fix40 = FIXDictionary.load spec('FIX40')
    @fix41 = FIXDictionary.load spec('FIX41')
    @fix42 = FIXDictionary.load spec('FIX42')
    @fix43 = FIXDictionary.load spec('FIX43')
    @fix44 = FIXDictionary.load spec('FIX44')
    @fix50 = FIXDictionary.load spec('FIX50')
    @fix50sp1 = FIXDictionary.load spec('FIX50SP1')
    @fix50sp2 = FIXDictionary.load spec('FIX50SP2')
    @fixfxcm10 = FIXDictionary.load spec('FIXFXCM10')
    @src_path  = File.join File.dirname(__FILE__), '..', 'QuickFIXn'

    @ext_path  = File.join File.dirname(__FILE__), '..', 'Extensions'
    Dir.mkdir(@ext_path) unless File.exists?(@ext_path)
    @fxcm_path = File.join @ext_path, 'FXCM'
    Dir.mkdir(@fxcm_path) unless File.exists?(@fxcm_path)
  end

  def spec fixver
    File.join File.dirname(__FILE__), "..", "spec", "fix", "#{fixver}.xml"
  end
    
  def generate_fields
    fields_path = File.join(@src_path, 'Fields', 'Fields.cs')
    tags_path   = File.join(@src_path, 'Fields', 'FieldTags.cs')
    FieldGen.generate(agg_fields,  fields_path, tags_path, "")

    fxcm_fields = File.join(@fxcm_path,'Fields')
    Dir.mkdir(fxcm_fields) unless File.exists?(fxcm_fields)
    fxcm_fields_path = File.join(fxcm_fields, 'Fields.cs')
    fxcm_tags_path   = File.join(fxcm_fields, 'FieldTags.cs')
    FieldGen.generate(agg_fieldsx, fxcm_fields_path, fxcm_tags_path, "FXCM")
  end

  def agg_fields
    field_names = (@fix40.fields.keys + @fix41.fields.keys +
        @fix42.fields.keys + @fix43.fields.keys +
        @fix44.fields.keys + @fix50.fields.keys +
        @fix50sp1.fields.keys + @fix50sp2.fields.keys).uniq
    field_names.map {|fn| get_field_def(fn) }
  end

  def agg_fieldsx
    field_names = (@fixfxcm10.fields.keys).uniq
    field_names.map {|fn| get_field_defx(fn) }
  end

  def get_field_def fld_name
    # we give priority to latest fix version
    fld = merge_field_defs(
      @fix50sp2.fields[fld_name],
      @fix50sp1.fields[fld_name],
      @fix50.fields[fld_name],
      @fix44.fields[fld_name],
      @fix43.fields[fld_name],
      @fix42.fields[fld_name],
      @fix41.fields[fld_name],
      @fix40.fields[fld_name]
    )
    
    raise "couldn't find field! #{fld}" if fld.nil?
    fld
  end

  def get_field_defx fld_name
    # we give priority to latest fix version
    fld = merge_field_defs(
      @fixfxcm10.fields[fld_name]
    )
    raise "couldn't find field! #{fld}" if fld.nil?
    fld
  end

  def merge_field_defs *alldefs
    defs = alldefs.reject {|d| d.nil?}
    return nil if defs.empty?
    fld = defs.first
    
    vals = defs.map { |d| d[:values] }.reject { |d| d.nil? }.flatten
    return fld if vals.empty?
    vals = vals.inject([]) {|saved, v| saved << v unless saved.detect {|u| u[:desc] == v[:desc]}; saved}
    fld[:values] = vals
    fld
  end

  def generate_messages
    msgs_path = File.join(@src_path, 'Message')
    MessageGen.generate(@fix40.messages,  msgs_path, 'FIX40')
    MessageGen.generate(@fix41.messages,  msgs_path, 'FIX41')
    MessageGen.generate(@fix42.messages,  msgs_path, 'FIX42')
    MessageGen.generate(@fix43.messages,  msgs_path, 'FIX43')
    MessageGen.generate(@fix44.messages,  msgs_path, 'FIX44')
    MessageGen.generate(@fix50.messages,  msgs_path, 'FIX50')
    MessageGen.generate(@fix50sp1.messages,  msgs_path, 'FIX50SP1')
    MessageGen.generate(@fix50sp2.messages,  msgs_path, 'FIX50SP2')

    fxcm_msgs_path = File.join(@fxcm_path, 'Message')
    Dir.mkdir(fxcm_msgs_path) unless File.exists?(fxcm_msgs_path)
    MessageGen.generate(@fixfxcm10.messages, fxcm_msgs_path, 'FXCM', true)
  end

  def generate_csproj
    csproj_path = File.join(@src_path, 'FixMessages.csproj')
    CSProjGen.generate(
      csproj_path,
      [
        {:version=>'FIX40', :messages=>@fix40.messages},
        {:version=>'FIX41', :messages=>@fix41.messages},
        {:version=>'FIX42', :messages=>@fix42.messages},
        {:version=>'FIX43', :messages=>@fix43.messages},
        {:version=>'FIX44', :messages=>@fix44.messages},
        #{:version=>'FIX44', :messages=>@fixfxcm10.messages},
        {:version=>'FIX50', :messages=>@fix50.messages}
      ]
    )
  end

  def generate_message_factories
    msgs_path = File.join(@src_path, 'Message')
    MessageFactoryGen.generate(@fix40.messages,  msgs_path, 'FIX40')
    MessageFactoryGen.generate(@fix41.messages,  msgs_path, 'FIX41')
    MessageFactoryGen.generate(@fix42.messages,  msgs_path, 'FIX42')
    MessageFactoryGen.generate(@fix43.messages,  msgs_path, 'FIX43')
    MessageFactoryGen.generate(@fix44.messages,  msgs_path, 'FIX44')
    MessageFactoryGen.generate(@fix50.messages,  msgs_path, 'FIX50')
    MessageFactoryGen.generate(@fix50sp1.messages,  msgs_path, 'FIX50SP1')
    MessageFactoryGen.generate(@fix50sp2.messages,  msgs_path, 'FIX50SP2')

    fxcm_msgs_path = File.join(@fxcm_path, 'Message')
    Dir.mkdir(fxcm_msgs_path) unless File.exists?(fxcm_msgs_path)
    MessageFactoryGen.generate(@fixfxcm10.messages, fxcm_msgs_path, 'FXCM', true)
  end
end


Generator.generate
