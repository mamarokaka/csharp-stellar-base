          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================
//  enum ThresholdIndexes
//  {
//      THRESHOLD_MASTER_WEIGHT = 0,
//      THRESHOLD_LOW = 1,
//      THRESHOLD_MED = 2,
//      THRESHOLD_HIGH = 3
//  };
//  ===========================================================================
public class ThresholdIndexes {
  public enum ThresholdIndexesEnum
  {
  THRESHOLD_MASTER_WEIGHT = 0,
  THRESHOLD_LOW = 1,
  THRESHOLD_MED = 2,
  THRESHOLD_HIGH = 3,
  }

  public ThresholdIndexesEnum InnerValue { get; set; } = default(ThresholdIndexesEnum);

  public static ThresholdIndexes Create(ThresholdIndexesEnum v)
  {
    return new ThresholdIndexes {
      InnerValue = v
    };
  }

  public static ThresholdIndexes Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(ThresholdIndexesEnum.THRESHOLD_MASTER_WEIGHT);
      case 1: return Create(ThresholdIndexesEnum.THRESHOLD_LOW);
      case 2: return Create(ThresholdIndexesEnum.THRESHOLD_MED);
      case 3: return Create(ThresholdIndexesEnum.THRESHOLD_HIGH);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, ThresholdIndexes value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
