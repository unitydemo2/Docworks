import com.eviware.soapui.testSuite.TestRunner.Status
com.eviware.soapui.Groovyutils
def tc = testRunner.testCase.testSuite.project.testSuites["API"].testCases["GetResponse"]
def runner = tc.run( null , TRUE)
assert runner.status = Status.Failed : runner.reason