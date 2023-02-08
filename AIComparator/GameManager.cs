using System.Collections.Generic;
using System.Linq;
using AIComparator.GamePlay;

namespace AIComparator;

public static class GameManager
{
    public static List<Player> Players { get; } = new();
    public static TeamStrategy? StrategyTeam1 { get; set; }
    public static TeamStrategy? StrategyTeam2 { get; set; }
    public static List<Player> Team1 => Players.Where(x => x.Team == 1).ToList();
    public static List<Player> Team2 => Players.Where(x => x.Team == 2).ToList();

    public static void Initialize()
    {
        CreateTeam(6, 50, 100, 1);
        CreateTeam(6, 750, 100, 2);
    }

    public static void CreateTeam(int numberOfPeople, int initialX, int initialY, int team)
    {
        for (int i = 0; i < numberOfPeople; i++)
        {
            Players.Add(new()
            {
                X = initialX,
                Y = initialY * i,
                Team = team,
                Velocity = 100.0f
            });
        }
    }

    public static void Update(float elapsedTime)
    {
        StrategyTeam1?.Update(elapsedTime);
        StrategyTeam2?.Update(elapsedTime);

        foreach (var player in Players)
        {
            player.Update(elapsedTime);
        }
    }
}