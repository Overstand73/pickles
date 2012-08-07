﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code

using TechTalk.SpecFlow;

#pragma warning disable

namespace Pickles.Example.xUnit.Features._031ScenarioContext
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ScenarioContextFeaturesFeature : Xunit.IUseFixture<ScenarioContextFeaturesFeature.FixtureData>,
                                                          System.IDisposable
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "ScenarioContext.feature"
#line hidden

        public ScenarioContextFeaturesFeature()
        {
            this.TestInitialize();
        }

        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                                                                "Scenario Context features",
                                                                "In order to show how to use ScenarioContext\r\nAs a SpecFlow evangelist\r\nI want to " +
                                                                "write some simple scenarios with data in ScenarioContext",
                                                                ProgrammingLanguage.CSharp, ((string[]) (null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void TestInitialize()
        {
        }

        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        public virtual void SetFixture(ScenarioContextFeaturesFeature.FixtureData fixtureData)
        {
        }

        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario Context features")]
        [Xunit.TraitAttribute("Description", "Store and retrive Person Marcus from ScenarioContext")]
        public virtual void StoreAndRetrivePersonMarcusFromScenarioContext()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "Store and retrive Person Marcus from ScenarioContext", ((string[]) (null)));
#line 6
            this.ScenarioSetup(scenarioInfo);
#line 7
            testRunner.When("I store a person called Marcus in the Current ScenarioContext");
#line 8
            testRunner.Then("a person called Marcus can easily be retrieved");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario Context features")]
        [Xunit.TraitAttribute("Description", "Showing information of the scenario")]
        public virtual void ShowingInformationOfTheScenario()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Showing information of the scenario", new string[]
                                                                                                             {
                                                                                                                 "showUpInScenarioInfo"
                                                                                                                 ,
                                                                                                                 "andThisToo"
                                                                                                             });
#line 11
            this.ScenarioSetup(scenarioInfo);
#line 12
            testRunner.When("I execute any scenario");
#line hidden
            var table1 = new TechTalk.SpecFlow.Table(new string[]
                                                         {
                                                             "Field",
                                                             "Value"
                                                         });
            table1.AddRow(new string[]
                              {
                                  "Tags",
                                  "showUpInScenarioInfo, andThisToo"
                              });
            table1.AddRow(new string[]
                              {
                                  "Title",
                                  "Showing information of the scenario"
                              });
#line 13
            testRunner.Then("the ScenarioInfo contains the following information", ((string) (null)), table1);
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario Context features")]
        [Xunit.TraitAttribute("Description", "Show the type of step we\'re currently on")]
        public virtual void ShowTheTypeOfStepWeReCurrentlyOn()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Show the type of step we\'re currently on",
                                                                  ((string[]) (null)));
#line 18
            this.ScenarioSetup(scenarioInfo);
#line 19
            testRunner.Given("I have a Given step");
#line 20
            testRunner.And("I have another Given step");
#line 21
            testRunner.When("I have a When step");
#line 22
            testRunner.Then("I have a Then step");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute(Skip = "Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario Context features")]
        [Xunit.TraitAttribute("Description", "Display error information in AfterScenario")]
        public virtual void DisplayErrorInformationInAfterScenario()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display error information in AfterScenario",
                                                                  new string[]
                                                                      {
                                                                          "ignore",
                                                                          "showingErrorHandling"
                                                                      });
#line 27
            this.ScenarioSetup(scenarioInfo);
#line 28
            testRunner.When("an error occurs in a step");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario Context features")]
        [Xunit.TraitAttribute("Description", "Pending step")]
        public virtual void PendingStep()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pending step", ((string[]) (null)));
#line 30
            this.ScenarioSetup(scenarioInfo);
#line 31
            testRunner.When("I set the ScenarioContext.Current to pending");
#line 32
            testRunner.Then("this step will not even be executed");
#line hidden
            this.ScenarioCleanup();
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            public FixtureData()
            {
                FeatureSetup();
            }

            #region IDisposable Members

            void System.IDisposable.Dispose()
            {
                FeatureTearDown();
            }

            #endregion
        }
    }
}

#pragma warning restore

#endregion