FRAMEWORK_DIR=$(shell reg query "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\14.0" /v MSBuildToolsPath | sed -n '3,1{s/ \+[^ ]\+ \+[^ ]\+ \+//; s!\\!/!g; s![Cc]:!/c!; s/\([ ()]\)/\\&/g; p}')
MSBUILD_EXE=$(FRAMEWORK_DIR)/MsBuild.exe
SRC_DIR=.
BUILD_DIR=.
SOLUTION=$(notdir $(wildcard $(SRC_DIR)/*.sln))

ifeq "" "$(MSBUILD_EXE)"
    $(error MsBuild.exe not found in: $(MSBUILD_EXE))
endif

verbosity ?= minimal

CONSTANTS=$(if $(or $(debug),$(trace)),/p:DefineConstants="DEBUG;TRACE")

all:
	cd $(SRC_DIR) && $(MSBUILD_EXE) $(SOLUTION) $(CONSTANTS) \
        /verbosity:$(verbosity) /m /maxcpucount:4 /t:Rebuild \
        /p:Configuration=Debug;TargetFrameworkVersion=v4.5;Optimize=false,DebugSymbols=true;Platform=AnyCPU \

run:
	cd $(BUILD_DIR)/Debug && ./$(basename $(SOLUTION)).exe &

info:
	@echo "MSBuild: $(MSBUILD_EXE)"

help:
	@$(MSBUILD_EXE) /?

install:
	$(GACUTIL_DIR)/gacutil /?
