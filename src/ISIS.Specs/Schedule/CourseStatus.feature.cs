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
    [NUnit.Framework.DescriptionAttribute("Course Status")]
    public partial class CourseStatusFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CourseStatus.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Course Status", "In order to control registration for sections\nAs a scheduler\nI want to manage the" +
                    " status of courses", GenerationTargetLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Activate an inactive course")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ActivateAnInactiveCourse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Activate an inactive course", new string[] {
                        "domain"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have created an ACAD course BIOL 1301 Introductory Biology");
#line 9
 testRunner.And("I have deactivated the course");
#line 10
 testRunner.When("I activate the course");
#line 11
 testRunner.Then("the course is active");
#line 12
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Activate an already-active course")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ActivateAnAlready_ActiveCourse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Activate an already-active course", new string[] {
                        "domain"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("I have created an ACAD course BIOL 1301 Introductory Biology");
#line 17
 testRunner.When("I activate the course");
#line 18
 testRunner.Then("it should do nothing");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deactivate a course")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void DeactivateACourse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deactivate a course", new string[] {
                        "domain"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("I have created an ACAD course BIOL 1301 Introductory Biology");
#line 23
 testRunner.When("I deactivate the course");
#line 24
 testRunner.Then("the course is inactive");
#line 25
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deactivate an already-inactive course")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void DeactivateAnAlready_InactiveCourse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deactivate an already-inactive course", new string[] {
                        "domain"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given("I have created an ACAD course BIOL 1301 Introductory Biology");
#line 30
 testRunner.And("I have deactivated the course");
#line 31
 testRunner.When("I deactivate the course");
#line 32
 testRunner.Then("it should do nothing");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Make a course pending")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void MakeACoursePending()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a course pending", new string[] {
                        "domain"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("I have created an ACAD course BIOL 1301 Introductory Biology");
#line 37
 testRunner.When("I make the course pending");
#line 38
 testRunner.Then("the course is pending");
#line 39
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Make an already-pending course pending")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void MakeAnAlready_PendingCoursePending()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make an already-pending course pending", new string[] {
                        "domain"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.Given("I have created an ACAD course BIOL 1301 Introductory Biology");
#line 44
 testRunner.And("I have made the course pending");
#line 45
 testRunner.When("I make the course pending");
#line 46
 testRunner.Then("it should do nothing");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Make a course obsolete")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void MakeACourseObsolete()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a course obsolete", new string[] {
                        "domain"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("I have created an ACAD course BIOL 1301 Introductory Biology");
#line 51
 testRunner.When("I make the course obsolete");
#line 52
 testRunner.Then("the course is obsolete");
#line 53
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Make an already-obsolete course obsolete")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void MakeAnAlready_ObsoleteCourseObsolete()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make an already-obsolete course obsolete", new string[] {
                        "domain"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given("I have created an ACAD course BIOL 1301 Introductory Biology");
#line 58
 testRunner.And("I have made the course obsolete");
#line 59
 testRunner.When("I make the course obsolete");
#line 60
 testRunner.Then("it should do nothing");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion