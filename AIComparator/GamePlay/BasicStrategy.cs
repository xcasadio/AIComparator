using System;
using System.Collections.Generic;

namespace AIComparator.GamePlay;

public class BasicStrategy : TeamStrategy
{
    public BasicStrategy(IList<Player> players, IList<Player> enemies) : base(players, enemies)
    {
    }

    public override void Update(float elapsedTime)
    {

    }
}