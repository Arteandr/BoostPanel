namespace BoostPanel.Server
{
    public interface IPlayer
    {
        bool Connected { get; set; }

        void Reset();
        
        string login { get; set; }
        
        ulong steam_id { get; set; }

        void OnMessage(string msg);
    }
}