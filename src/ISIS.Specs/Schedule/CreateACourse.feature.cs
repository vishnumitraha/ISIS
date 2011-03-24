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
    [NUnit.Framework.DescriptionAttribute("Create A Course")]
    public partial class CreateACourseFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateACourse.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Create A Course", "In order to manage the course schedule\nAs a scheduler\nI want to set up a new cour" +
                    "se", GenerationTargetLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Create a credit course")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void CreateACreditCourse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a credit course", new string[] {
                        "domain"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.When("I create an ACAD course BIOL 1301 Introductory Biology");
#line 9
 testRunner.Then("the course is created");
#line 10
 testRunner.And("the course rubric is BIOL");
#line 11
 testRunner.And("the course number is 1301");
#line 12
 testRunner.And("the course title is Introductory Biology");
#line 13
 testRunner.And("the course long title is Introductory Biology");
#line 14
 testRunner.And("the course is active");
#line 15
 testRunner.And("the ACAD course type is added");
#line 16
 testRunner.And("the current course type is ACAD");
#line 17
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a CE course")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void CreateACECourse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a CE course", new string[] {
                        "domain"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.When("I create a Workforce Funded course AGEQ 1091 Routine Management of Equine Health");
#line 22
 testRunner.Then("the course is created");
#line 23
 testRunner.And("the course rubric is AGEQ");
#line 24
 testRunner.And("the course number is 1091");
#line 25
 testRunner.And("the course title is Routine Management of Equine H");
#line 26
 testRunner.And("the course long title is Routine Management of Equine Health");
#line 27
 testRunner.And("the course is active");
#line 28
 testRunner.And("the CWECM course type is added");
#line 29
 testRunner.And("the current course type is CWECM");
#line 30
 testRunner.And("the credit type is Workforce Funded");
#line 31
 testRunner.And("the CEUs are 0");
#line 32
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
