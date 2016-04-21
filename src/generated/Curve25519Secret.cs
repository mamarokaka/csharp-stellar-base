          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================
//  struct Curve25519Secret
//  {
//          opaque key[32];
//  };
//  ===========================================================================
public class Curve25519Secret {
  public Curve25519Secret () {}
  public byte[] Key { get; set; }
  public static void Encode(IByteWriter stream, Curve25519Secret encodedCurve25519Secret) {
    int keysize = encodedCurve25519Secret.Key.Length;
    XdrEncoding.WriteFixOpaque(stream, (uint)keysize, encodedCurve25519Secret.Key);
  }
  public static Curve25519Secret Decode(IByteReader stream) {
    Curve25519Secret decodedCurve25519Secret = new Curve25519Secret();
    int keysize = 32;
    decodedCurve25519Secret.Key = XdrEncoding.ReadFixOpaque(stream, (uint)keysize);
    return decodedCurve25519Secret;
  }
}
}
