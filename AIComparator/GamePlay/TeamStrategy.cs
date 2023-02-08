using System.Collections.Generic;

namespace AIComparator.GamePlay;

public abstract class TeamStrategy
{
    protected readonly IList<Player> _players;
    protected readonly IList<Player> _enemies;

    protected TeamStrategy(IList<Player> players, IList<Player> enemies)
    {
        _players = players;
        _enemies = enemies;
    }

    public abstract void Update(float elapsedTime);
}