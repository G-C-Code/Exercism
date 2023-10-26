using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }
    public FacialFeatures(string eyeColor, decimal philtrumWidth) => (EyeColor, PhiltrumWidth) = (eyeColor, philtrumWidth);

    public override bool Equals(object obj) => (obj is FacialFeatures other)
        ? EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth
        : false;

    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }
    public Identity(string email, FacialFeatures facialFeatures) => (Email, FacialFeatures) = (email , facialFeatures);

    public override bool Equals(object obj) => obj is Identity other
        ? Email == other.Email && FacialFeatures.Equals(other.FacialFeatures)
        : false;

    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures);
}

public class Authenticator
{
    private HashSet<Identity> Identities = new HashSet<Identity>();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity) => identity.Email == "admin@exerc.ism" && identity.FacialFeatures.EyeColor == "green" && identity.FacialFeatures.PhiltrumWidth == 0.9m;

    public bool Register(Identity identity) => Identities.Add(identity);

    public bool IsRegistered(Identity identity) => Identities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => object.ReferenceEquals(identityA, identityB);
}
