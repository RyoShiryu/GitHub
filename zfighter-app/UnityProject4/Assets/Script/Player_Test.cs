using UnityEngine;
using System.Collections;
using SharpUnit;

namespace SharpUnit
{
	public class Player_Test : TestCase {

	    public bool m_wasRun = false;       // True if this test was run.
	    public bool m_wasSetup = false;     // True if this test was setup.
	    public bool m_wasTornDown = false;  // True if the test was torn down.
  		private Player tester = new Player();

	    public override void SetUp()
	    {
	        m_wasSetup = true;
			tester.getName();
	    }

	    /**
	     */
	    public override void TearDown()
	    {
	        m_wasTornDown = true;
	    }

	    /**
	     */
	    [UnitTest]
	    public void TestMethod()
	    {
	        m_wasRun = true;
	    }

	    /**
	     */
	    [UnitTest]
	    public void TestFail()
	    {
	        // Test should fail
	        Assert.True(false, "Expected fail result.");
	    }
	}
}