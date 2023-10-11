using System;

public enum AccountType
{
    Guest,
    User,
    Moderator
}
[Flags]
public enum Permission
{
    Read = 1,
    Write = 2,
    Delete = 4,
    All = Read | Write | Delete,
    None = 0
}
static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        switch (accountType)
        {
            case AccountType.Guest:
                return Permission.Read;
            case AccountType.User:
                return Permission.Read | Permission.Write;
            case AccountType.Moderator:
                return Permission.All;
            default:
                return Permission.None;
        }
    }

        public static Permission Grant(Permission current, Permission grant)
        {
        if (current == Permission.None)
            return grant;
        else if (current == Permission.All)
            return current;
        else
            return current | grant;
        }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        if (current == Permission.None || revoke == Permission.None)
            return current;
        else if (current == Permission.All)
            return current & ~revoke;
        else
            return current & ~revoke;
    }

    public static bool Check(Permission current, Permission check) => (current & check) == check;
}
