          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================
//  enum AssetType
//  {
//      ASSET_TYPE_NATIVE = 0,
//      ASSET_TYPE_CREDIT_ALPHANUM4 = 1,
//      ASSET_TYPE_CREDIT_ALPHANUM12 = 2
//  };
//  ===========================================================================
public class AssetType {
  public enum AssetTypeEnum
  {
  ASSET_TYPE_NATIVE = 0,
  ASSET_TYPE_CREDIT_ALPHANUM4 = 1,
  ASSET_TYPE_CREDIT_ALPHANUM12 = 2,
  }

  public AssetTypeEnum InnerValue { get; set; } = default(AssetTypeEnum);

  public static AssetType Create(AssetTypeEnum v)
  {
    return new AssetType {
      InnerValue = v
    };
  }

  public static AssetType Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(AssetTypeEnum.ASSET_TYPE_NATIVE);
      case 1: return Create(AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4);
      case 2: return Create(AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM12);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, AssetType value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
