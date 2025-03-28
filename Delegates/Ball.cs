namespace Events;

class BallEventArgs(int angle, int distance) : EventArgs
{
    public int Angle { get; private set; } = angle;
    public int Distance { get; private set; } = distance;
}

internal class Ball
{
    public event EventHandler<BallEventArgs> BallInPlay;
    public void OnBallInPlay(BallEventArgs e) => BallInPlay?.Invoke(this, e);
}

class Pitcher
{
    public Pitcher(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;
    private int pitchNumber = 0;
    private void BallInPlayEventHandler(object? sender, BallEventArgs e)
    {
        pitchNumber++;
        if (e.Distance < 95 && e.Angle < 60)
            Console.WriteLine($"Pitch #{pitchNumber}: I caught the ball");
        else
            Console.WriteLine($"Pitch #{pitchNumber}: I covered first base");
    }
}

class Fan
{
    private int pitchNumber = 0;
    public Fan(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;

    private void BallInPlayEventHandler(object? sender, BallEventArgs e)
    {
        pitchNumber++;
        if (e is BallEventArgs ballEventArgs)
        {
            if (ballEventArgs.Distance > 400 && ballEventArgs.Angle > 30)
                Console.WriteLine($"Pitch #{pitchNumber}: Home run! I’m going for the ball!");
            else
                Console.WriteLine($"Pitch #{pitchNumber}: Woo-hoo! Yeah!");
        }
    }
}
