          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================
//  union PathPaymentResult switch (PathPaymentResultCode code)
//  {
//  case PATH_PAYMENT_SUCCESS:
//      struct
//      {
//          ClaimOfferAtom offers<>;
//          SimplePaymentResult last;
//      } success;
//  case PATH_PAYMENT_NO_ISSUER:
//      Asset noIssuer; // the asset that caused the error
//  default:
//      void;
//  };
//  ===========================================================================
public class PathPaymentResult {
  public PathPaymentResult () {}
  public PathPaymentResultCode Discriminant { get; set; } = new PathPaymentResultCode();
  public PathPaymentResultSuccess Success { get; set; } = default(PathPaymentResultSuccess);
  public Asset NoIssuer { get; set; } = default(Asset);
  public static void Encode(IByteWriter stream, PathPaymentResult encodedPathPaymentResult) {
  XdrEncoding.EncodeInt32((int)encodedPathPaymentResult.Discriminant.InnerValue, stream);
  switch (encodedPathPaymentResult.Discriminant.InnerValue) {
  case PathPaymentResultCode.PathPaymentResultCodeEnum.PATH_PAYMENT_SUCCESS:
  PathPaymentResultSuccess.Encode(stream, encodedPathPaymentResult.Success);
  break;
  case PathPaymentResultCode.PathPaymentResultCodeEnum.PATH_PAYMENT_NO_ISSUER:
  Asset.Encode(stream, encodedPathPaymentResult.NoIssuer);
  break;
  default:
  break;
  }
  }
  public static PathPaymentResult Decode(IByteReader stream) {
    PathPaymentResult decodedPathPaymentResult = new PathPaymentResult();
  decodedPathPaymentResult.Discriminant = PathPaymentResultCode.Decode(stream);
  switch (decodedPathPaymentResult.Discriminant.InnerValue) {
  case PathPaymentResultCode.PathPaymentResultCodeEnum.PATH_PAYMENT_SUCCESS:
  decodedPathPaymentResult.Success = PathPaymentResultSuccess.Decode(stream);
  break;
  case PathPaymentResultCode.PathPaymentResultCodeEnum.PATH_PAYMENT_NO_ISSUER:
  decodedPathPaymentResult.NoIssuer = Asset.Decode(stream);
  break;
  default:
  break;
  }
    return decodedPathPaymentResult;
  }

  public class PathPaymentResultSuccess {
    public PathPaymentResultSuccess () {}
    public ClaimOfferAtom[] Offers { get; set; }
    public SimplePaymentResult Last { get; set; }
    public static void Encode(IByteWriter stream, PathPaymentResultSuccess encodedPathPaymentResultSuccess) {
      int offerssize = encodedPathPaymentResultSuccess.Offers.Length;
      XdrEncoding.EncodeInt32(offerssize, stream);
      for (int i = 0; i < offerssize; i++) {
        ClaimOfferAtom.Encode(stream, encodedPathPaymentResultSuccess.Offers[i]);
      }
      SimplePaymentResult.Encode(stream, encodedPathPaymentResultSuccess.Last);
    }
    public static PathPaymentResultSuccess Decode(IByteReader stream) {
      PathPaymentResultSuccess decodedPathPaymentResultSuccess = new PathPaymentResultSuccess();
      int offerssize = XdrEncoding.DecodeInt32(stream);
      decodedPathPaymentResultSuccess.Offers = new ClaimOfferAtom[offerssize];
      for (int i = 0; i < offerssize; i++) {
        decodedPathPaymentResultSuccess.Offers[i] = ClaimOfferAtom.Decode(stream);
      }
      decodedPathPaymentResultSuccess.Last = SimplePaymentResult.Decode(stream);
      return decodedPathPaymentResultSuccess;
    }

  }
}
}
