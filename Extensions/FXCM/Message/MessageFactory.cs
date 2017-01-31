// This is a generated file.  Don't edit it directly!

namespace QuickFix.FXCM
{
    public class MessageFactory : IMessageFactory
    {
            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FXCM.Heartbeat.MsgType: return new QuickFix.FXCM.Heartbeat();
                    case QuickFix.FXCM.Logon.MsgType: return new QuickFix.FXCM.Logon();
                    case QuickFix.FXCM.TestRequest.MsgType: return new QuickFix.FXCM.TestRequest();
                    case QuickFix.FXCM.ResendRequest.MsgType: return new QuickFix.FXCM.ResendRequest();
                    case QuickFix.FXCM.Reject.MsgType: return new QuickFix.FXCM.Reject();
                    case QuickFix.FXCM.SequenceReset.MsgType: return new QuickFix.FXCM.SequenceReset();
                    case QuickFix.FXCM.Logout.MsgType: return new QuickFix.FXCM.Logout();
                    case QuickFix.FXCM.BusinessMessageReject.MsgType: return new QuickFix.FXCM.BusinessMessageReject();
                    case QuickFix.FXCM.UserRequest.MsgType: return new QuickFix.FXCM.UserRequest();
                    case QuickFix.FXCM.UserResponse.MsgType: return new QuickFix.FXCM.UserResponse();
                    case QuickFix.FXCM.Advertisement.MsgType: return new QuickFix.FXCM.Advertisement();
                    case QuickFix.FXCM.IndicationOfInterest.MsgType: return new QuickFix.FXCM.IndicationOfInterest();
                    case QuickFix.FXCM.News.MsgType: return new QuickFix.FXCM.News();
                    case QuickFix.FXCM.Email.MsgType: return new QuickFix.FXCM.Email();
                    case QuickFix.FXCM.QuoteRequest.MsgType: return new QuickFix.FXCM.QuoteRequest();
                    case QuickFix.FXCM.QuoteResponse.MsgType: return new QuickFix.FXCM.QuoteResponse();
                    case QuickFix.FXCM.QuoteRequestReject.MsgType: return new QuickFix.FXCM.QuoteRequestReject();
                    case QuickFix.FXCM.RFQRequest.MsgType: return new QuickFix.FXCM.RFQRequest();
                    case QuickFix.FXCM.Quote.MsgType: return new QuickFix.FXCM.Quote();
                    case QuickFix.FXCM.QuoteCancel.MsgType: return new QuickFix.FXCM.QuoteCancel();
                    case QuickFix.FXCM.QuoteStatusRequest.MsgType: return new QuickFix.FXCM.QuoteStatusRequest();
                    case QuickFix.FXCM.QuoteStatusReport.MsgType: return new QuickFix.FXCM.QuoteStatusReport();
                    case QuickFix.FXCM.MassQuote.MsgType: return new QuickFix.FXCM.MassQuote();
                    case QuickFix.FXCM.MassQuoteAcknowledgement.MsgType: return new QuickFix.FXCM.MassQuoteAcknowledgement();
                    case QuickFix.FXCM.MarketDataRequest.MsgType: return new QuickFix.FXCM.MarketDataRequest();
                    case QuickFix.FXCM.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FXCM.MarketDataSnapshotFullRefresh();
                    case QuickFix.FXCM.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FXCM.MarketDataIncrementalRefresh();
                    case QuickFix.FXCM.MarketDataRequestReject.MsgType: return new QuickFix.FXCM.MarketDataRequestReject();
                    case QuickFix.FXCM.SecurityDefinitionRequest.MsgType: return new QuickFix.FXCM.SecurityDefinitionRequest();
                    case QuickFix.FXCM.SecurityDefinition.MsgType: return new QuickFix.FXCM.SecurityDefinition();
                    case QuickFix.FXCM.SecurityTypeRequest.MsgType: return new QuickFix.FXCM.SecurityTypeRequest();
                    case QuickFix.FXCM.SecurityTypes.MsgType: return new QuickFix.FXCM.SecurityTypes();
                    case QuickFix.FXCM.SecurityListRequest.MsgType: return new QuickFix.FXCM.SecurityListRequest();
                    case QuickFix.FXCM.SecurityList.MsgType: return new QuickFix.FXCM.SecurityList();
                    case QuickFix.FXCM.DerivativeSecurityListRequest.MsgType: return new QuickFix.FXCM.DerivativeSecurityListRequest();
                    case QuickFix.FXCM.DerivativeSecurityList.MsgType: return new QuickFix.FXCM.DerivativeSecurityList();
                    case QuickFix.FXCM.SecurityStatusRequest.MsgType: return new QuickFix.FXCM.SecurityStatusRequest();
                    case QuickFix.FXCM.SecurityStatus.MsgType: return new QuickFix.FXCM.SecurityStatus();
                    case QuickFix.FXCM.TradingSessionStatusRequest.MsgType: return new QuickFix.FXCM.TradingSessionStatusRequest();
                    case QuickFix.FXCM.TradingSessionStatus.MsgType: return new QuickFix.FXCM.TradingSessionStatus();
                    case QuickFix.FXCM.NewOrderSingle.MsgType: return new QuickFix.FXCM.NewOrderSingle();
                    case QuickFix.FXCM.ExecutionReport.MsgType: return new QuickFix.FXCM.ExecutionReport();
                    case QuickFix.FXCM.DontKnowTrade.MsgType: return new QuickFix.FXCM.DontKnowTrade();
                    case QuickFix.FXCM.OrderCancelReplaceRequest.MsgType: return new QuickFix.FXCM.OrderCancelReplaceRequest();
                    case QuickFix.FXCM.OrderCancelRequest.MsgType: return new QuickFix.FXCM.OrderCancelRequest();
                    case QuickFix.FXCM.OrderCancelReject.MsgType: return new QuickFix.FXCM.OrderCancelReject();
                    case QuickFix.FXCM.OrderStatusRequest.MsgType: return new QuickFix.FXCM.OrderStatusRequest();
                    case QuickFix.FXCM.OrderMassCancelRequest.MsgType: return new QuickFix.FXCM.OrderMassCancelRequest();
                    case QuickFix.FXCM.OrderMassCancelReport.MsgType: return new QuickFix.FXCM.OrderMassCancelReport();
                    case QuickFix.FXCM.OrderMassStatusRequest.MsgType: return new QuickFix.FXCM.OrderMassStatusRequest();
                    case QuickFix.FXCM.NewOrderCross.MsgType: return new QuickFix.FXCM.NewOrderCross();
                    case QuickFix.FXCM.CrossOrderCancelReplaceRequest.MsgType: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest();
                    case QuickFix.FXCM.CrossOrderCancelRequest.MsgType: return new QuickFix.FXCM.CrossOrderCancelRequest();
                    case QuickFix.FXCM.NewOrderMultileg.MsgType: return new QuickFix.FXCM.NewOrderMultileg();
                    case QuickFix.FXCM.MultilegOrderCancelReplaceRequest.MsgType: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest();
                    case QuickFix.FXCM.BidRequest.MsgType: return new QuickFix.FXCM.BidRequest();
                    case QuickFix.FXCM.BidResponse.MsgType: return new QuickFix.FXCM.BidResponse();
                    case QuickFix.FXCM.NewOrderList.MsgType: return new QuickFix.FXCM.NewOrderList();
                    case QuickFix.FXCM.ListStrikePrice.MsgType: return new QuickFix.FXCM.ListStrikePrice();
                    case QuickFix.FXCM.ListStatus.MsgType: return new QuickFix.FXCM.ListStatus();
                    case QuickFix.FXCM.ListExecute.MsgType: return new QuickFix.FXCM.ListExecute();
                    case QuickFix.FXCM.ListCancelRequest.MsgType: return new QuickFix.FXCM.ListCancelRequest();
                    case QuickFix.FXCM.ListStatusRequest.MsgType: return new QuickFix.FXCM.ListStatusRequest();
                    case QuickFix.FXCM.AllocationInstruction.MsgType: return new QuickFix.FXCM.AllocationInstruction();
                    case QuickFix.FXCM.AllocationInstructionAck.MsgType: return new QuickFix.FXCM.AllocationInstructionAck();
                    case QuickFix.FXCM.AllocationReport.MsgType: return new QuickFix.FXCM.AllocationReport();
                    case QuickFix.FXCM.AllocationReportAck.MsgType: return new QuickFix.FXCM.AllocationReportAck();
                    case QuickFix.FXCM.Confirmation.MsgType: return new QuickFix.FXCM.Confirmation();
                    case QuickFix.FXCM.ConfirmationAck.MsgType: return new QuickFix.FXCM.ConfirmationAck();
                    case QuickFix.FXCM.ConfirmationRequest.MsgType: return new QuickFix.FXCM.ConfirmationRequest();
                    case QuickFix.FXCM.SettlementInstructions.MsgType: return new QuickFix.FXCM.SettlementInstructions();
                    case QuickFix.FXCM.SettlementInstructionRequest.MsgType: return new QuickFix.FXCM.SettlementInstructionRequest();
                    case QuickFix.FXCM.TradeCaptureReportRequest.MsgType: return new QuickFix.FXCM.TradeCaptureReportRequest();
                    case QuickFix.FXCM.TradeCaptureReportRequestAck.MsgType: return new QuickFix.FXCM.TradeCaptureReportRequestAck();
                    case QuickFix.FXCM.TradeCaptureReport.MsgType: return new QuickFix.FXCM.TradeCaptureReport();
                    case QuickFix.FXCM.TradeCaptureReportAck.MsgType: return new QuickFix.FXCM.TradeCaptureReportAck();
                    case QuickFix.FXCM.RegistrationInstructions.MsgType: return new QuickFix.FXCM.RegistrationInstructions();
                    case QuickFix.FXCM.RegistrationInstructionsResponse.MsgType: return new QuickFix.FXCM.RegistrationInstructionsResponse();
                    case QuickFix.FXCM.PositionMaintenanceRequest.MsgType: return new QuickFix.FXCM.PositionMaintenanceRequest();
                    case QuickFix.FXCM.PositionMaintenanceReport.MsgType: return new QuickFix.FXCM.PositionMaintenanceReport();
                    case QuickFix.FXCM.RequestForPositions.MsgType: return new QuickFix.FXCM.RequestForPositions();
                    case QuickFix.FXCM.RequestForPositionsAck.MsgType: return new QuickFix.FXCM.RequestForPositionsAck();
                    case QuickFix.FXCM.PositionReport.MsgType: return new QuickFix.FXCM.PositionReport();
                    case QuickFix.FXCM.AssignmentReport.MsgType: return new QuickFix.FXCM.AssignmentReport();
                    case QuickFix.FXCM.CollateralRequest.MsgType: return new QuickFix.FXCM.CollateralRequest();
                    case QuickFix.FXCM.CollateralAssignment.MsgType: return new QuickFix.FXCM.CollateralAssignment();
                    case QuickFix.FXCM.CollateralResponse.MsgType: return new QuickFix.FXCM.CollateralResponse();
                    case QuickFix.FXCM.CollateralReport.MsgType: return new QuickFix.FXCM.CollateralReport();
                    case QuickFix.FXCM.CollateralInquiry.MsgType: return new QuickFix.FXCM.CollateralInquiry();
                    case QuickFix.FXCM.NetworkStatusRequest.MsgType: return new QuickFix.FXCM.NetworkStatusRequest();
                    case QuickFix.FXCM.NetworkStatusResponse.MsgType: return new QuickFix.FXCM.NetworkStatusResponse();
                    case QuickFix.FXCM.CollateralInquiryAck.MsgType: return new QuickFix.FXCM.CollateralInquiryAck();
                    case QuickFix.FXCM.FXCMNewsRequest.MsgType: return new QuickFix.FXCM.FXCMNewsRequest();
                    case QuickFix.FXCM.FXCMNewsTopicRequest.MsgType: return new QuickFix.FXCM.FXCMNewsTopicRequest();
                    case QuickFix.FXCM.FXCMRequestReject.MsgType: return new QuickFix.FXCM.FXCMRequestReject();
                    case QuickFix.FXCM.FXCMNewsTopicResponse.MsgType: return new QuickFix.FXCM.FXCMNewsTopicResponse();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FXCM.Logon.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoMsgTypes: return new QuickFix.FXCM.Logon.NoMsgTypesGroup();
                    }
                }

                if (QuickFix.FXCM.UserRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.FXCMNoParam: return new QuickFix.FXCM.UserRequest.FXCMNoParamGroup();
                    }
                }

                if (QuickFix.FXCM.UserResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.UserResponse.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.FXCMNoParam: return new QuickFix.FXCM.UserResponse.FXCMNoParamGroup();
                    }
                }

                if (QuickFix.FXCM.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.Advertisement.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.Advertisement.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.Advertisement.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.Advertisement.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.Advertisement.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.Advertisement.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.Advertisement.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.IndicationOfInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.IndicationOfInterest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.IndicationOfInterest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.IndicationOfInterest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.IndicationOfInterest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.IndicationOfInterest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.IndicationOfInterest.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.IndicationOfInterest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.IndicationOfInterest.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.IndicationOfInterest.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoIOIQualifiers: return new QuickFix.FXCM.IndicationOfInterest.NoIOIQualifiersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoRoutingIDs: return new QuickFix.FXCM.IndicationOfInterest.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FXCM.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoRoutingIDs: return new QuickFix.FXCM.News.NoRoutingIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoRelatedSym: return new QuickFix.FXCM.News.NoRelatedSymGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.News.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.News.NoRelatedSymGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.News.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.News.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.News.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.News.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.News.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.LinesOfText: return new QuickFix.FXCM.News.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FXCM.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoRoutingIDs: return new QuickFix.FXCM.Email.NoRoutingIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoRelatedSym: return new QuickFix.FXCM.Email.NoRelatedSymGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.Email.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.Email.NoRelatedSymGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.Email.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.Email.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.Email.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.Email.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.Email.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.LinesOfText: return new QuickFix.FXCM.Email.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FXCM.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoRelatedSym: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoQuoteQualifiersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.QuoteResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FXCM.QuoteResponse.NoQuoteQualifiersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.QuoteResponse.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.QuoteResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.QuoteResponse.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.QuoteResponse.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.QuoteResponse.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.QuoteResponse.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.QuoteResponse.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.QuoteResponse.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.QuoteResponse.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoRelatedSym: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FXCM.QuoteRequestReject.NoQuoteQualifiersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.QuoteRequestReject.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.QuoteRequestReject.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoRelatedSym: return new QuickFix.FXCM.RFQRequest.NoRelatedSymGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.RFQRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.RFQRequest.NoRelatedSymGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.RFQRequest.NoRelatedSymGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FXCM.Quote.NoQuoteQualifiersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.Quote.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.Quote.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.Quote.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.Quote.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.Quote.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.Quote.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.Quote.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.Quote.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.Quote.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.Quote.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.Quote.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.Quote.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.Quote.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.QuoteCancel.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.QuoteCancel.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoQuoteEntries: return new QuickFix.FXCM.QuoteCancel.NoQuoteEntriesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.QuoteCancel.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.QuoteCancel.NoQuoteEntriesGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.QuoteStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.QuoteStatusRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.QuoteStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.QuoteStatusRequest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.QuoteStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.QuoteStatusRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.QuoteStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.QuoteStatusReport.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.QuoteStatusReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.QuoteStatusReport.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.QuoteStatusReport.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.QuoteStatusReport.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.QuoteStatusReport.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.QuoteStatusReport.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.QuoteStatusReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.QuoteStatusReport.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FXCM.QuoteStatusReport.NoQuoteQualifiersGroup();
                    }
                }

                if (QuickFix.FXCM.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.MassQuote.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.MassQuote.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoQuoteSets: return new QuickFix.FXCM.MassQuote.NoQuoteSetsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.MassQuote.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.MassQuote.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoQuoteEntries: return new QuickFix.FXCM.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoQuoteSets: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoQuoteSetsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoQuoteEntries: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoMDEntryTypes: return new QuickFix.FXCM.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoRelatedSym: return new QuickFix.FXCM.MarketDataRequest.NoRelatedSymGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.MarketDataRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.MarketDataRequest.NoRelatedSymGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.MarketDataRequest.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FXCM.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.MarketDataSnapshotFullRefresh.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.MarketDataSnapshotFullRefresh.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMDEntries: return new QuickFix.FXCM.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FXCM.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoMDEntries: return new QuickFix.FXCM.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoAltMDSource: return new QuickFix.FXCM.MarketDataRequestReject.NoAltMDSourceGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.MarketDataRequestReject.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.MarketDataRequestReject.NoEventsGroup();
                    }
                }

                if (QuickFix.FXCM.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.SecurityDefinitionRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.SecurityDefinitionRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.SecurityDefinitionRequest.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.SecurityDefinitionRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.SecurityDefinitionRequest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.SecurityDefinitionRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.SecurityDefinition.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.SecurityDefinition.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.SecurityDefinition.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.SecurityDefinition.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.SecurityDefinition.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.SecurityDefinition.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityTypes: return new QuickFix.FXCM.SecurityTypes.NoSecurityTypesGroup();
                    }
                }

                if (QuickFix.FXCM.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.SecurityListRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.SecurityListRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.SecurityListRequest.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.SecurityListRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.SecurityListRequest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.SecurityListRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoRelatedSym: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
                    }
                }

                if (QuickFix.FXCM.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.DerivativeSecurityList.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoRelatedSym: return new QuickFix.FXCM.DerivativeSecurityList.NoRelatedSymGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.DerivativeSecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.DerivativeSecurityList.NoRelatedSymGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.DerivativeSecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.SecurityStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.SecurityStatusRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.SecurityStatusRequest.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.SecurityStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.SecurityStatusRequest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.SecurityStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.SecurityStatus.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.SecurityStatus.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.SecurityStatus.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.SecurityStatus.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.SecurityStatus.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.SecurityStatus.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.TradingSessionStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoRelatedSym: return new QuickFix.FXCM.TradingSessionStatus.NoRelatedSymGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.TradingSessionStatus.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.TradingSessionStatus.NoRelatedSymGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.FXCMNoParam: return new QuickFix.FXCM.TradingSessionStatus.FXCMNoParamGroup();
                    }
                }

                if (QuickFix.FXCM.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.NewOrderSingle.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.NewOrderSingle.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.NewOrderSingle.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.NewOrderSingle.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.NewOrderSingle.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.NewOrderSingle.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.NewOrderSingle.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.NewOrderSingle.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FXCM.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.ExecutionReport.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.ExecutionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoContraBrokers: return new QuickFix.FXCM.ExecutionReport.NoContraBrokersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.ExecutionReport.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.ExecutionReport.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.ExecutionReport.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.ExecutionReport.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoContAmts: return new QuickFix.FXCM.ExecutionReport.NoContAmtsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.ExecutionReport.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.ExecutionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.ExecutionReport.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.ExecutionReport.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.ExecutionReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMiscFees: return new QuickFix.FXCM.ExecutionReport.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FXCM.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.DontKnowTrade.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.DontKnowTrade.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.DontKnowTrade.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.DontKnowTrade.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.DontKnowTrade.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.OrderCancelRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.OrderCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.OrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.OrderCancelRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.OrderCancelRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.OrderStatusRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.OrderStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.OrderStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.OrderStatusRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.OrderStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.OrderMassCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.OrderMassCancelRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.OrderMassCancelRequest.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoAffectedOrders: return new QuickFix.FXCM.OrderMassCancelReport.NoAffectedOrdersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.OrderMassCancelReport.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.OrderMassCancelReport.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.OrderMassCancelReport.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.OrderMassStatusRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.OrderMassStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.OrderMassStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.OrderMassStatusRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.OrderMassStatusRequest.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSides: return new QuickFix.FXCM.NewOrderCross.NoSidesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.NewOrderCross.NoSidesGroup.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.NewOrderCross.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.NewOrderCross.NoSidesGroup.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.NewOrderCross.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.NewOrderCross.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.NewOrderCross.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.NewOrderCross.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.NewOrderCross.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.NewOrderCross.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.NewOrderCross.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FXCM.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSides: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoSidesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FXCM.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSides: return new QuickFix.FXCM.CrossOrderCancelRequest.NoSidesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.CrossOrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.CrossOrderCancelRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.CrossOrderCancelRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.CrossOrderCancelRequest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.CrossOrderCancelRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.NewOrderMultileg.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.NewOrderMultileg.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.NewOrderMultileg.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FXCM.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FXCM.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.NewOrderMultileg.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.NewOrderMultileg.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.NewOrderMultileg.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.NewOrderMultileg.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.NewOrderMultileg.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.NewOrderMultileg.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.NewOrderMultileg.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegAllocs: return new QuickFix.FXCM.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FXCM.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FXCM.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.MultilegOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoAllocsGroup.NoNested3PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegAllocs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoBidDescriptors: return new QuickFix.FXCM.BidRequest.NoBidDescriptorsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoBidComponents: return new QuickFix.FXCM.BidRequest.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FXCM.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoBidComponents: return new QuickFix.FXCM.BidResponse.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FXCM.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoOrders: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.NewOrderList.NoOrdersGroup.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FXCM.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoStrikes: return new QuickFix.FXCM.ListStrikePrice.NoStrikesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.ListStrikePrice.NoStrikesGroup.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.ListStrikePrice.NoStrikesGroup.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.ListStrikePrice.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoOrders: return new QuickFix.FXCM.ListStatus.NoOrdersGroup();
                    }
                }

                if (QuickFix.FXCM.AllocationInstruction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoOrders: return new QuickFix.FXCM.AllocationInstruction.NoOrdersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FXCM.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FXCM.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoExecs: return new QuickFix.FXCM.AllocationInstruction.NoExecsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.AllocationInstruction.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.AllocationInstruction.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.AllocationInstruction.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.AllocationInstruction.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.AllocationInstruction.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.AllocationInstruction.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.AllocationInstruction.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.AllocationInstruction.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.AllocationInstruction.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.AllocationInstruction.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMiscFees: return new QuickFix.FXCM.AllocationInstruction.NoAllocsGroup.NoMiscFeesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoDlvyInst: return new QuickFix.FXCM.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FXCM.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FXCM.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.AllocationInstructionAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.AllocationInstructionAck.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.AllocationInstructionAck.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.AllocationInstructionAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FXCM.AllocationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoOrders: return new QuickFix.FXCM.AllocationReport.NoOrdersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FXCM.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FXCM.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoExecs: return new QuickFix.FXCM.AllocationReport.NoExecsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.AllocationReport.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.AllocationReport.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.AllocationReport.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.AllocationReport.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.AllocationReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.AllocationReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.AllocationReport.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.AllocationReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.AllocationReport.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.AllocationReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.AllocationReport.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.AllocationReport.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMiscFees: return new QuickFix.FXCM.AllocationReport.NoAllocsGroup.NoMiscFeesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoClearingInstructions: return new QuickFix.FXCM.AllocationReport.NoAllocsGroup.NoClearingInstructionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoDlvyInst: return new QuickFix.FXCM.AllocationReport.NoAllocsGroup.NoDlvyInstGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FXCM.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FXCM.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.AllocationReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.AllocationReportAck.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.AllocationReportAck.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.AllocationReportAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FXCM.Confirmation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.Confirmation.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.Confirmation.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoOrders: return new QuickFix.FXCM.Confirmation.NoOrdersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FXCM.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FXCM.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FXCM.Confirmation.NoTrdRegTimestampsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.Confirmation.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.Confirmation.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.Confirmation.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.Confirmation.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.Confirmation.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.Confirmation.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.Confirmation.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.Confirmation.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoCapacities: return new QuickFix.FXCM.Confirmation.NoCapacitiesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoDlvyInst: return new QuickFix.FXCM.Confirmation.NoDlvyInstGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FXCM.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FXCM.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.Confirmation.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMiscFees: return new QuickFix.FXCM.Confirmation.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FXCM.ConfirmationRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoOrders: return new QuickFix.FXCM.ConfirmationRequest.NoOrdersGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FXCM.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FXCM.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSettlInst: return new QuickFix.FXCM.SettlementInstructions.NoSettlInstGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoDlvyInst: return new QuickFix.FXCM.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FXCM.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FXCM.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.SettlementInstructionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.SettlementInstructionRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.SettlementInstructionRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.TradeCaptureReportRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.TradeCaptureReportRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.TradeCaptureReportRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.TradeCaptureReportRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoInstrAttrib: return new QuickFix.FXCM.TradeCaptureReportRequest.NoInstrAttribGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.TradeCaptureReportRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.TradeCaptureReportRequest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.TradeCaptureReportRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoDates: return new QuickFix.FXCM.TradeCaptureReportRequest.NoDatesGroup();
                    }
                }

                if (QuickFix.FXCM.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.TradeCaptureReportRequestAck.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.TradeCaptureReportRequestAck.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.TradeCaptureReportRequestAck.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (QuickFix.FXCM.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.TradeCaptureReport.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.TradeCaptureReport.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.TradeCaptureReport.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPosAmt: return new QuickFix.FXCM.TradeCaptureReport.NoPosAmtGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.TradeCaptureReport.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.TradeCaptureReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.TradeCaptureReport.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FXCM.TradeCaptureReport.NoTrdRegTimestampsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSides: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoClearingInstructions: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup.NoClearingInstructionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoContAmts: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup.NoContAmtsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMiscFees: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup.NoMiscFeesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FXCM.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.TradeCaptureReportAck.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.TradeCaptureReportAck.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FXCM.TradeCaptureReportAck.NoTrdRegTimestampsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.TradeCaptureReportAck.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.TradeCaptureReportAck.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegStipulations: return new QuickFix.FXCM.TradeCaptureReportAck.NoLegsGroup.NoLegStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoAllocs: return new QuickFix.FXCM.TradeCaptureReportAck.NoAllocsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FXCM.TradeCaptureReportAck.NoAllocsGroup.NoNested2PartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FXCM.TradeCaptureReportAck.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.RegistrationInstructions.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.RegistrationInstructions.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoRegistDtls: return new QuickFix.FXCM.RegistrationInstructions.NoRegistDtlsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoDistribInsts: return new QuickFix.FXCM.RegistrationInstructions.NoDistribInstsGroup();
                    }
                }

                if (QuickFix.FXCM.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.RegistrationInstructionsResponse.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.RegistrationInstructionsResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.PositionMaintenanceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.PositionMaintenanceRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.PositionMaintenanceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.PositionMaintenanceRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.PositionMaintenanceRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.PositionMaintenanceRequest.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.PositionMaintenanceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.PositionMaintenanceRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.PositionMaintenanceRequest.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPositions: return new QuickFix.FXCM.PositionMaintenanceRequest.NoPositionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.PositionMaintenanceReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.PositionMaintenanceReport.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.PositionMaintenanceReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.PositionMaintenanceReport.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.PositionMaintenanceReport.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.PositionMaintenanceReport.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.PositionMaintenanceReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.PositionMaintenanceReport.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.PositionMaintenanceReport.NoTradingSessionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPositions: return new QuickFix.FXCM.PositionMaintenanceReport.NoPositionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPosAmt: return new QuickFix.FXCM.PositionMaintenanceReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FXCM.RequestForPositions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.RequestForPositions.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.RequestForPositions.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.RequestForPositions.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.RequestForPositions.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.RequestForPositions.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.RequestForPositions.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.RequestForPositions.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTradingSessions: return new QuickFix.FXCM.RequestForPositions.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FXCM.RequestForPositionsAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.RequestForPositionsAck.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.RequestForPositionsAck.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.RequestForPositionsAck.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.RequestForPositionsAck.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.RequestForPositionsAck.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.RequestForPositionsAck.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.RequestForPositionsAck.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.PositionReport.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.PositionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.PositionReport.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.PositionReport.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegs: return new QuickFix.FXCM.PositionReport.NoLegsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.PositionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.PositionReport.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.PositionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.PositionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPositions: return new QuickFix.FXCM.PositionReport.NoPositionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPosAmt: return new QuickFix.FXCM.PositionReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FXCM.AssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.AssignmentReport.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.AssignmentReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.AssignmentReport.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.AssignmentReport.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.AssignmentReport.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.AssignmentReport.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPositions: return new QuickFix.FXCM.AssignmentReport.NoPositionsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FXCM.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FXCM.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPosAmt: return new QuickFix.FXCM.AssignmentReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FXCM.CollateralRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.CollateralRequest.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.CollateralRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoExecs: return new QuickFix.FXCM.CollateralRequest.NoExecsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrades: return new QuickFix.FXCM.CollateralRequest.NoTradesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.CollateralRequest.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.CollateralRequest.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.CollateralRequest.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.CollateralRequest.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FXCM.CollateralRequest.NoTrdRegTimestampsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMiscFees: return new QuickFix.FXCM.CollateralRequest.NoMiscFeesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.CollateralRequest.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FXCM.CollateralAssignment.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.CollateralAssignment.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.CollateralAssignment.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoExecs: return new QuickFix.FXCM.CollateralAssignment.NoExecsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrades: return new QuickFix.FXCM.CollateralAssignment.NoTradesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.CollateralAssignment.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.CollateralAssignment.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.CollateralAssignment.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.CollateralAssignment.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FXCM.CollateralAssignment.NoTrdRegTimestampsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMiscFees: return new QuickFix.FXCM.CollateralAssignment.NoMiscFeesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.CollateralAssignment.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoDlvyInst: return new QuickFix.FXCM.CollateralAssignment.NoDlvyInstGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FXCM.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FXCM.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.CollateralResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.CollateralResponse.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.CollateralResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoExecs: return new QuickFix.FXCM.CollateralResponse.NoExecsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrades: return new QuickFix.FXCM.CollateralResponse.NoTradesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.CollateralResponse.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.CollateralResponse.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.CollateralResponse.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.CollateralResponse.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FXCM.CollateralResponse.NoTrdRegTimestampsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMiscFees: return new QuickFix.FXCM.CollateralResponse.NoMiscFeesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.CollateralResponse.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FXCM.CollateralReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.CollateralReport.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.CollateralReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoExecs: return new QuickFix.FXCM.CollateralReport.NoExecsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrades: return new QuickFix.FXCM.CollateralReport.NoTradesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.CollateralReport.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.CollateralReport.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.CollateralReport.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.CollateralReport.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.CollateralReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.CollateralReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FXCM.CollateralReport.NoTrdRegTimestampsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoMiscFees: return new QuickFix.FXCM.CollateralReport.NoMiscFeesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.CollateralReport.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoDlvyInst: return new QuickFix.FXCM.CollateralReport.NoDlvyInstGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FXCM.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FXCM.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.CollateralInquiry.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FXCM.CollateralInquiry.NoCollInquiryQualifierGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.CollateralInquiry.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoExecs: return new QuickFix.FXCM.CollateralInquiry.NoExecsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrades: return new QuickFix.FXCM.CollateralInquiry.NoTradesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.CollateralInquiry.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.CollateralInquiry.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.CollateralInquiry.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.CollateralInquiry.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FXCM.CollateralInquiry.NoTrdRegTimestampsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoStipulations: return new QuickFix.FXCM.CollateralInquiry.NoStipulationsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoDlvyInst: return new QuickFix.FXCM.CollateralInquiry.NoDlvyInstGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FXCM.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FXCM.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
                    }
                }

                if (QuickFix.FXCM.NetworkStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoCompIDs: return new QuickFix.FXCM.NetworkStatusRequest.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FXCM.NetworkStatusResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoCompIDs: return new QuickFix.FXCM.NetworkStatusResponse.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FXCM.CollateralInquiryAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FXCM.CollateralInquiryAck.NoCollInquiryQualifierGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartyIDs: return new QuickFix.FXCM.CollateralInquiryAck.NoPartyIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoPartySubIDs: return new QuickFix.FXCM.CollateralInquiryAck.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoExecs: return new QuickFix.FXCM.CollateralInquiryAck.NoExecsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoTrades: return new QuickFix.FXCM.CollateralInquiryAck.NoTradesGroup();
                        case QuickFix.FXCM.Fields.Tags.NoSecurityAltID: return new QuickFix.FXCM.CollateralInquiryAck.NoSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoEvents: return new QuickFix.FXCM.CollateralInquiryAck.NoEventsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FXCM.CollateralInquiryAck.NoLegSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyings: return new QuickFix.FXCM.CollateralInquiryAck.NoUnderlyingsGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FXCM.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.FXCM.Fields.Tags.NoUnderlyingStips: return new QuickFix.FXCM.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FXCM.FXCMNewsRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.FXCMPageIDNo: return new QuickFix.FXCM.FXCMNewsRequest.FXCMPageIDNoGroup();
                    }
                }

                if (QuickFix.FXCM.FXCMNewsTopicResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.FXCM.Fields.Tags.FXCMPageIDNo: return new QuickFix.FXCM.FXCMNewsTopicResponse.FXCMPageIDNoGroup();
                    }
                }

                return null;
            }

    }
}
