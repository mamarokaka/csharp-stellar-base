          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================
//  enum LedgerEntryChangeType
//  {
//      LEDGER_ENTRY_CREATED = 0, // entry was added to the ledger
//      LEDGER_ENTRY_UPDATED = 1, // entry was modified in the ledger
//      LEDGER_ENTRY_REMOVED = 2, // entry was removed from the ledger
//      LEDGER_ENTRY_STATE = 3    // value of the entry
//  };
//  ===========================================================================
public class LedgerEntryChangeType {
  public enum LedgerEntryChangeTypeEnum
  {
  LEDGER_ENTRY_CREATED = 0,
  LEDGER_ENTRY_UPDATED = 1,
  LEDGER_ENTRY_REMOVED = 2,
  LEDGER_ENTRY_STATE = 3,
  }

  public LedgerEntryChangeTypeEnum InnerValue { get; set; } = default(LedgerEntryChangeTypeEnum);

  public static LedgerEntryChangeType Create(LedgerEntryChangeTypeEnum v)
  {
    return new LedgerEntryChangeType {
      InnerValue = v
    };
  }

  public static LedgerEntryChangeType Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(LedgerEntryChangeTypeEnum.LEDGER_ENTRY_CREATED);
      case 1: return Create(LedgerEntryChangeTypeEnum.LEDGER_ENTRY_UPDATED);
      case 2: return Create(LedgerEntryChangeTypeEnum.LEDGER_ENTRY_REMOVED);
      case 3: return Create(LedgerEntryChangeTypeEnum.LEDGER_ENTRY_STATE);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, LedgerEntryChangeType value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
