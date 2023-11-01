using System;

public class Orm : IDisposable
{
    private readonly Database _db;

    public Orm(Database db) => _db = db;

    public void Begin() => _db.BeginTransaction();

    public void Write(string data)
    {
        try
        {
            _db.Write(data);
        }
        catch
        {
            _db.Dispose();
        }
    }

    public void Commit()
    {
        try
        {
            _db.EndTransaction();
        }
        catch
        {
            _db.Dispose();
        }
    }

    public void Dispose() => _db.Dispose();
}

