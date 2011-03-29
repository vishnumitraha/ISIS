// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace ISIS.Schedule
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Sections")]
    public partial class SectionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Sections.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Sections", "In order to manage the course schedule\nAs a scheduler\nI want to manage sections", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a CE section without a topic code")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void CreateACESectionWithoutATopicCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a CE section without a topic code", new string[] {
                        "domain"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 10
 testRunner.And("I have changed the approval number to 1234567890");
#line 11
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 12
 testRunner.When("I create section 01 from the course with term CE211Q1");
#line 13
 testRunner.Then("the section\'s rubric is AGEQ");
#line 14
 testRunner.And("the section\'s course number is 1091");
#line 15
 testRunner.And("the section\'s section number is 01");
#line 16
 testRunner.And("the section\'s term is CE211Q1");
#line 17
 testRunner.And("the section\'s start date is not set");
#line 18
 testRunner.And("the section\'s end date is not set");
#line 19
 testRunner.And("the section\'s title is Routine Management of Equine H");
#line 20
 testRunner.And("the section\'s credit type is Workforce Funded");
#line 21
 testRunner.And("the section\'s course type is CWECM");
#line 22
 testRunner.And("the section\'s current course type is CWECM");
#line 23
 testRunner.And("the section\'s approval number is 1234567890");
#line 24
 testRunner.And("the section\'s CIP is 123456");
#line 25
 testRunner.And("the section\'s status is pending");
#line 26
 testRunner.And("the location is blank");
#line 27
 testRunner.And("the section\'s CEUs is 0");
#line 28
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a CE section with a topic code")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void CreateACESectionWithATopicCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a CE section with a topic code", new string[] {
                        "domain"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 33
 testRunner.And("I have changed the approval number to 1234567890");
#line 34
 testRunner.And("I have created a topic code BANK Banking/Finance");
#line 35
 testRunner.And("I have changed the course\'s topic code to BANK Banking/Finance");
#line 36
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 37
 testRunner.When("I create section 01 from the course with term CE211Q1");
#line 38
 testRunner.And("the section\'s topic code is BANK");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can create a CE section from a special interests course without an approval or CI" +
            "P")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void CanCreateACESectionFromASpecialInterestsCourseWithoutAnApprovalOrCIP()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can create a CE section from a special interests course without an approval or CI" +
                    "P", new string[] {
                        "domain"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
 testRunner.Given("I have created a Special Interests course AGEQ 1091 Routine Management of Equine " +
                    "Health");
#line 43
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 44
 testRunner.When("I create section 01 from the course with term CE211Q1");
#line 45
 testRunner.Then("the section is created");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cant create a CE section from a non-special interests course without an approval " +
            "or CIP")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void CantCreateACESectionFromANon_SpecialInterestsCourseWithoutAnApprovalOrCIP()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cant create a CE section from a non-special interests course without an approval " +
                    "or CIP", new string[] {
                        "domain"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 50
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 51
 testRunner.When("I create section 01 from the course with term CE211Q1");
#line 52
 testRunner.Then("the aggregate state is invalid");
#line 53
 testRunner.And("the error is \"Your attempt to create a section failed. The course doesn\'t have an" +
                    " approval number or CIP, and it\'s not a special interests course.\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section number")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section number", new string[] {
                        "domain"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 58
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 59
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 60
 testRunner.When("I change the section number to 02");
#line 61
 testRunner.Then("the section number is 02");
#line 62
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section number when the section number is taken")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionNumberWhenTheSectionNumberIsTaken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section number when the section number is taken", new string[] {
                        "domain"});
#line 65
this.ScenarioSetup(scenarioInfo);
#line 66
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 67
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 68
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 69
 testRunner.And("I have created a section 02 from the course with term CE211Q1");
#line 70
 testRunner.When("I change the section number to 02");
#line 71
 testRunner.Then("the command is invalid");
#line 72
 testRunner.And("the error is \"Your attempt to create a section failed. That section number is alr" +
                    "eady used.\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section term")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionTerm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section term", new string[] {
                        "domain"});
#line 75
this.ScenarioSetup(scenarioInfo);
#line 76
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 77
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 78
 testRunner.And("I have created a term CE211Q2 from 12/1/2011 to 2/28/2012");
#line 79
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 80
 testRunner.When("I change the section\'s term to CE211Q2");
#line 81
 testRunner.Then("the section\'s term is CE211Q2");
#line 82
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section term when the section number is taken")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionTermWhenTheSectionNumberIsTaken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section term when the section number is taken", new string[] {
                        "domain"});
#line 85
this.ScenarioSetup(scenarioInfo);
#line 86
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 87
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 88
 testRunner.And("I have created a term CE211Q2 from 12/1/2011 to 2/28/2012");
#line 89
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 90
 testRunner.And("I have created a section 01 from the course with term CE211Q2");
#line 91
 testRunner.When("I change the section\'s term to CE211Q2");
#line 92
 testRunner.Then("the command is invalid");
#line 93
 testRunner.And("the error is \"Your attempt to create a section failed. That section number is alr" +
                    "eady used.\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section dates")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionDates()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section dates", new string[] {
                        "domain"});
#line 96
this.ScenarioSetup(scenarioInfo);
#line 97
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 98
 testRunner.And("I have changed the approval number to 1234567890");
#line 99
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 100
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 101
 testRunner.When("I change the start date to 10/1/2011 and the end date to 11/1/2011");
#line 102
 testRunner.Then("the section start date is 10/1/2011");
#line 103
 testRunner.And("the section end date is 11/1/2011");
#line 104
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section dates where the section dates are before the term")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionDatesWhereTheSectionDatesAreBeforeTheTerm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section dates where the section dates are before the term", new string[] {
                        "domain"});
#line 107
this.ScenarioSetup(scenarioInfo);
#line 108
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 109
 testRunner.And("I have changed the approval number to 1234567890");
#line 110
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 111
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 112
 testRunner.When("I change the start date to 7/1/2011 and the end date to 8/1/2011");
#line 113
 testRunner.Then("the command is invalid");
#line 114
 testRunner.And("the error is \"Your attempt to create a section failed. The section census date is" +
                    " outside the term dates.\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section dates where the section dates are after the term")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionDatesWhereTheSectionDatesAreAfterTheTerm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section dates where the section dates are after the term", new string[] {
                        "domain"});
#line 117
this.ScenarioSetup(scenarioInfo);
#line 118
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 119
 testRunner.And("I have changed the approval number to 1234567890");
#line 120
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 121
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 122
 testRunner.When("I change the start date to 12/1/2011 and the end date to 12/25/2011");
#line 123
 testRunner.Then("the command is invalid");
#line 124
 testRunner.And("the error is \"Your attempt to create a section failed. The section census date is" +
                    " outside the term dates.\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section location")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionLocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section location", new string[] {
                        "domain"});
#line 127
this.ScenarioSetup(scenarioInfo);
#line 128
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 129
 testRunner.And("I have changed the approval number to 1234567890");
#line 130
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 131
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 132
 testRunner.When("I change the section location to ACC");
#line 133
 testRunner.Then("the section location is ACC");
#line 134
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section location to the same location")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionLocationToTheSameLocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section location to the same location", new string[] {
                        "domain"});
#line 137
this.ScenarioSetup(scenarioInfo);
#line 138
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 139
 testRunner.And("I have changed the approval number to 1234567890");
#line 140
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 141
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 142
 testRunner.And("I have changed the section location to ACC");
#line 143
 testRunner.When("I change the section location to ACC");
#line 144
 testRunner.Then("it should do nothing");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section credit type to non-funded")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionCreditTypeToNon_Funded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section credit type to non-funded", new string[] {
                        "domain"});
#line 147
this.ScenarioSetup(scenarioInfo);
#line 148
 testRunner.Given("I have created a Workforce Funded course AGEQ 1091 Routine Management of Equine H" +
                    "ealth");
#line 149
 testRunner.And("I have changed the approval number to 1234567890");
#line 150
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 151
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 152
 testRunner.When("I change the section credit type to Workforce Non-funded");
#line 153
 testRunner.Then("the section credit type should be Workforce Non-funded");
#line 154
 testRunner.And("the section course type should be CE");
#line 155
 testRunner.And("the section current course type should be CE");
#line 156
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section credit type to funded")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionCreditTypeToFunded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section credit type to funded", new string[] {
                        "domain"});
#line 159
this.ScenarioSetup(scenarioInfo);
#line 160
 testRunner.Given("I have created a Workforce Non-funded course AGEQ 1091 Routine Management of Equi" +
                    "ne Health");
#line 161
 testRunner.And("I have changed the approval number to 1234567890");
#line 162
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 163
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 164
 testRunner.When("I change the section credit type to Workforce Funded");
#line 165
 testRunner.Then("the section credit type should be Workforce Funded");
#line 166
 testRunner.And("the section course type should be CWECM");
#line 167
 testRunner.And("the section current course type should be CWECM");
#line 168
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section\'s CEUs")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionSCEUs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section\'s CEUs", new string[] {
                        "domain"});
#line 171
this.ScenarioSetup(scenarioInfo);
#line 172
 testRunner.Given("I have created a Workforce Non-funded course AGEQ 1091 Routine Management of Equi" +
                    "ne Health");
#line 173
 testRunner.And("I have changed the approval number to 1234567890");
#line 174
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 175
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 176
 testRunner.When("I change the section\'s CEUs to 0.70");
#line 177
 testRunner.Then("the section\'s CEUs is 0.70");
#line 178
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the section\'s title")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheSectionSTitle()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the section\'s title", new string[] {
                        "domain"});
#line 181
this.ScenarioSetup(scenarioInfo);
#line 182
 testRunner.Given("I have created a Workforce Non-funded course AGEQ 1091 Routine Management of Equi" +
                    "ne Health");
#line 183
 testRunner.And("I have changed the approval number to 1234567890");
#line 184
 testRunner.And("I have created a term CE211Q1 from 9/1/2011 to 11/30/2011");
#line 185
 testRunner.And("I have created a section 01 from the course with term CE211Q1");
#line 186
 testRunner.When("I change the section\'s title to Horses");
#line 187
 testRunner.Then("the section\'s title is Horses");
#line 188
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion