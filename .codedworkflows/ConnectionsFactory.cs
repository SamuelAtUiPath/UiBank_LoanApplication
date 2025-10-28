using UiPath.CodedWorkflows;
using System;

namespace UiBankLoanApplication_Tests
{
    public class ExcelFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection My_Workspace_samuel_simao_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection United_Kingdom_samuel_simao_uipath_com__2 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection France_samuel_simao_uipath_com__3 { get; set; }

        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("84fac2e8-d720-490b-80fd-a419f3fe1470", resolver);
            United_Kingdom_samuel_simao_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("f669c101-dc20-4142-a1d3-2adefeec7a98", resolver);
            France_samuel_simao_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("3821dff2-956b-4599-aea3-a2548dc18c87", resolver);
        }
    }

    public class O365MailFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_samuel_simao_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Brazil_Sao_Leopoldo_samuel_simao_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Tool_Automations_Productivity_Outlook_Automations_samuel_simao_uipath_com__2 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection United_Kingdom_samuel_simao_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection United_Kingdom_Liverpool_samuel_simao_uipath_com__4 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Uruguay_Montevideo_samuel_simao_uipath_com__5 { get; set; }

        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("a8eba03f-88de-4074-966b-8aabdba73215", resolver);
            Brazil_Sao_Leopoldo_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("9866f35b-729c-4cde-887a-ef9d1eb0e8eb", resolver);
            Tool_Automations_Productivity_Outlook_Automations_samuel_simao_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("fea7e875-d120-4416-beda-45b837f8ea35", resolver);
            United_Kingdom_samuel_simao_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("5523e947-25ea-4e4b-8a25-86051d28808a", resolver);
            United_Kingdom_Liverpool_samuel_simao_uipath_com__4 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("31a1e8fb-6551-462f-81ab-39332e7a8802", resolver);
            Uruguay_Montevideo_samuel_simao_uipath_com__5 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("d13d6135-39e7-4ed2-be31-f8339d4769af", resolver);
        }
    }

    public class OneDriveFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection My_Workspace_samuel_simao_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection United_Kingdom_samuel_simao_uipath_com__2 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection France_samuel_simao_uipath_com__3 { get; set; }

        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("84fac2e8-d720-490b-80fd-a419f3fe1470", resolver);
            United_Kingdom_samuel_simao_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("f669c101-dc20-4142-a1d3-2adefeec7a98", resolver);
            France_samuel_simao_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("3821dff2-956b-4599-aea3-a2548dc18c87", resolver);
        }
    }
}