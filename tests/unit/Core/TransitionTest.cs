using tomware.Microwf.Core;
using tomware.Microwf.TestsCommon.WorkflowDefinitions;
using Xunit;

namespace tomware.Microwf.UnitTests.Core
{
  public class TransitionTest
  {
    [Fact]
    public void Transition_NewInstance_CanMakeTransitionDefaultsToTrue()
    {
      // Arrange

      // Act
      var transition = new Transition();

      // Assert
      Assert.NotNull(transition);
      Assert.True(transition.CanMakeTransition(new TransitionContext(new Switcher())));
      Assert.Null(transition.BeforeTransition);
      Assert.Null(transition.AfterTransition);
    }
  }
}