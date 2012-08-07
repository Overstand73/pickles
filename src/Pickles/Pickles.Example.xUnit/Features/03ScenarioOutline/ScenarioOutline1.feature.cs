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

namespace Pickles.Example.xUnit.Features._03ScenarioOutline
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ScenarioOutlineFeature : Xunit.IUseFixture<ScenarioOutlineFeature.FixtureData>,
                                                  System.IDisposable
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "ScenarioOutline.feature"
#line hidden

        public ScenarioOutlineFeature()
        {
            this.TestInitialize();
        }

        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                                                                "Scenario outline",
                                                                "In order to not have to type the same scenario over and over\r\nAs a SpecFlow evang" +
                                                                "elist\r\nI want to show how to use ScenarioOutline",
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

        public virtual void SetFixture(ScenarioOutlineFeature.FixtureData fixtureData)
        {
        }

        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }

        [Xunit.Extensions.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario outline")]
        [Xunit.TraitAttribute("Description", "Add two positive numbers with many examples")]
        [Xunit.Extensions.InlineDataAttribute("10", "20", "30", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("20", "20", "40", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("20", "30", "50", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("100", "20", "120", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("1000", "20", "1020", new string[0])]
        public virtual void AddTwoPositiveNumbersWithManyExamples(string number1, string number2, string result,
                                                                  string[] exampleTags)
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two positive numbers with many examples",
                                                                  exampleTags);
#line 8
            this.ScenarioSetup(scenarioInfo);
#line 9
            testRunner.Given(string.Format("I ented {0} into the calculator", number1));
#line 10
            testRunner.And(string.Format("I enter {0} into the calculator", number2));
#line 11
            testRunner.When("I perform add");
#line 12
            testRunner.Then(string.Format("the result should be {0}", result));
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