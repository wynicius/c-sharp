using System;

public class Logs {

    public string Username { get; set; }
    public DateTime Instance { get; set; }

    public override int GetHashCode()
    {
        return Username.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Logs))
        {
            return false;
        }
        Logs other = obj as Logs;
        return Username.Equals(other.Username);
    }
}