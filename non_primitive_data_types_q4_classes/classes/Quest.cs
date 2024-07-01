namespace non_primitive_data_types_q4_classes;

// Question 4: Quest Class
// Create a class called "Quest" to represent tasks or missions in a quest-based game.
// Include properties for the quest's name, description, reward, and completion status.
// Implement methods to start the quest, complete the quest, and claim the reward.
// Hint: Define a class with attributes for name, description, reward, and completion status. Implement methods to manage quest progress.
/* Consider the structure of quests in games. They often involve objectives, rewards, and tracking completion status. */
class Quest
{
    private Status status;
    private string title;
    private string description;
    private List<Items> rewards;
    private int progress;

    public Quest(string title, string description, List<Items> rewards, int progress)
    {
        this.Status = Status.AVAILABLE;
        this.Title = title;
        this.Description = description;
        this.Rewards = rewards;
        this.Progress = progress;
    }

    public string Title { get => title; set => title = value; }
    public string Description { get => description; set => description = value; }
    public int Progress { get => progress; set => progress = value; }
    internal Status Status { get => status; set => status = value; }
    internal List<Items> Rewards { get => rewards; set => rewards = value; }

    public void ReachCheckPoint(Player player, int progress)
    {
        if (player != null)
        {
            this.progress += progress;
        }
        if (this.progress >= 100)
        {
            this.progress = 100;
            this.status = Status.WAIT_FOR_AWARD;
        }
    }

    public void AwardPlayer(Player player, List<Items> award)
    {
        if (this.status == Status.WAIT_FOR_AWARD)
        {
            player.Inventory.addItems(award);
        }
    }
}

enum Status
{
    AVAILABLE,
    INPROGRESS,
    WAIT_FOR_AWARD,
    FINISHED

}