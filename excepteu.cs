public class AnimationController
{
    private PausableAnimationContext _animationContext;

    public AnimationController()
    {
        _animationContext = new PausableAnimationContext { Name = "ExampleAnimation" };
    }

    public void RunAnimation()
    {
        _animationContext.Start();
        Console.WriteLine($"Animation {_animationContext.Name} started.");
    }

    public void PauseAnimation()
    {
        _animationContext.Pause();
        Console.WriteLine($"Animation {_animationContext.Name} paused.");
    }

    public void ResumeAnimation()
    {
        _animationContext.Resume();
        Console.WriteLine($"Animation {_animationContext.Name} resumed.");
    }

    public void StopAnimation()
    {
        _animationContext.Stop();
        Console.WriteLine($"Animation {_animationContext.Name} stopped.");
    }
}
