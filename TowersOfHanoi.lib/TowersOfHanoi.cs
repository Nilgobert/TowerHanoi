namespace TowersOfHanoi.lib;

public class TowersOfHanoi : ITowersOfHanoi
{
    private Stack<int>[] Tower = new Stack<int>[3];
    
    private int _discs;
    private bool even;
    private int lastTower = 1;
    
    //private int MoveTower     TO BE DONE
    
    private int StartDiscs
    {
        get { return _discs; }
        set
        {
            if (value <= )
        }
    }

    public TowersOfHanoi(int startDiscs)
    {
        Tower[0] = new Stack<int>();
        Tower[1] = new Stack<int>();
        Tower[2] = new Stack<int>();
        Restart(startDiscs);
    }
    public void Restart(int Amount)
    {
        Moves = 0;
        StartDiscs = Amount;
        Tower[0].Clear();
        Tower[1].Clear();
        Tower[2].Clear();
        for (int i = Amount; i > 0; i--)
        {
            Tower[0].Push(i);
        }

    }
    public int Moves { get; provate set; }

    public (int, int, int) CountDiscs()
    {
        return (Tower[0].Count, Tower[1].Count, Tower[2].Count);
    }

    public (int, int) MoveNext()
    {
        if (Tower[2] != null)
        {
            if (Tower[2])
        }
    }

    private (int, int) Move(int direction)
    {
        if (direction == -1 || direction == 1)
        {
            int actTower
        }
    }

}
