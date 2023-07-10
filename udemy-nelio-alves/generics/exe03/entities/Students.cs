class Students
{
    public int StudentId { get; set; }
    public string Course { get; set; }

    public override int GetHashCode()
    {
        return StudentId.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Students))
        {
            return false;
        }

        Students other = obj as Students;
        return StudentId.Equals(other.StudentId);
    }
}