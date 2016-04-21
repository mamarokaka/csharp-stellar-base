          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================
//  struct Operation
//  {
//      // sourceAccount is the account used to run the operation
//      // if not set, the runtime defaults to "sourceAccount" specified at
//      // the transaction level
//      AccountID* sourceAccount;
//  
//      union switch (OperationType type)
//      {
//      case CREATE_ACCOUNT:
//          CreateAccountOp createAccountOp;
//      case PAYMENT:
//          PaymentOp paymentOp;
//      case PATH_PAYMENT:
//          PathPaymentOp pathPaymentOp;
//      case MANAGE_OFFER:
//          ManageOfferOp manageOfferOp;
//      case CREATE_PASSIVE_OFFER:
//          CreatePassiveOfferOp createPassiveOfferOp;
//      case SET_OPTIONS:
//          SetOptionsOp setOptionsOp;
//      case CHANGE_TRUST:
//          ChangeTrustOp changeTrustOp;
//      case ALLOW_TRUST:
//          AllowTrustOp allowTrustOp;
//      case ACCOUNT_MERGE:
//          AccountID destination;
//      case INFLATION:
//          void;
//      case MANAGE_DATA:
//          ManageDataOp manageDataOp;
//      }
//      body;
//  };
//  ===========================================================================
public class Operation {
  public Operation () {}
  public AccountID SourceAccount { get; set; }
  public OperationBody Body { get; set; }
  public static void Encode(IByteWriter stream, Operation encodedOperation) {
    if (encodedOperation.SourceAccount != null) {
    XdrEncoding.EncodeInt32(1, stream);
    AccountID.Encode(stream, encodedOperation.SourceAccount);
    } else {
    XdrEncoding.EncodeInt32(0, stream);
    }
    OperationBody.Encode(stream, encodedOperation.Body);
  }
  public static Operation Decode(IByteReader stream) {
    Operation decodedOperation = new Operation();
    int sourceAccountPresent = XdrEncoding.DecodeInt32(stream);
    if (sourceAccountPresent != 0) {
    decodedOperation.SourceAccount = AccountID.Decode(stream);
    }
    decodedOperation.Body = OperationBody.Decode(stream);
    return decodedOperation;
  }

  public class OperationBody {
    public OperationBody () {}
    public OperationType Discriminant { get; set; } = new OperationType();
    public CreateAccountOp CreateAccountOp { get; set; } = default(CreateAccountOp);
    public PaymentOp PaymentOp { get; set; } = default(PaymentOp);
    public PathPaymentOp PathPaymentOp { get; set; } = default(PathPaymentOp);
    public ManageOfferOp ManageOfferOp { get; set; } = default(ManageOfferOp);
    public CreatePassiveOfferOp CreatePassiveOfferOp { get; set; } = default(CreatePassiveOfferOp);
    public SetOptionsOp SetOptionsOp { get; set; } = default(SetOptionsOp);
    public ChangeTrustOp ChangeTrustOp { get; set; } = default(ChangeTrustOp);
    public AllowTrustOp AllowTrustOp { get; set; } = default(AllowTrustOp);
    public AccountID Destination { get; set; } = default(AccountID);
    public ManageDataOp ManageDataOp { get; set; } = default(ManageDataOp);
    public static void Encode(IByteWriter stream, OperationBody encodedOperationBody) {
    XdrEncoding.EncodeInt32((int)encodedOperationBody.Discriminant.InnerValue, stream);
    switch (encodedOperationBody.Discriminant.InnerValue) {
    case OperationType.OperationTypeEnum.CREATE_ACCOUNT:
    CreateAccountOp.Encode(stream, encodedOperationBody.CreateAccountOp);
    break;
    case OperationType.OperationTypeEnum.PAYMENT:
    PaymentOp.Encode(stream, encodedOperationBody.PaymentOp);
    break;
    case OperationType.OperationTypeEnum.PATH_PAYMENT:
    PathPaymentOp.Encode(stream, encodedOperationBody.PathPaymentOp);
    break;
    case OperationType.OperationTypeEnum.MANAGE_OFFER:
    ManageOfferOp.Encode(stream, encodedOperationBody.ManageOfferOp);
    break;
    case OperationType.OperationTypeEnum.CREATE_PASSIVE_OFFER:
    CreatePassiveOfferOp.Encode(stream, encodedOperationBody.CreatePassiveOfferOp);
    break;
    case OperationType.OperationTypeEnum.SET_OPTIONS:
    SetOptionsOp.Encode(stream, encodedOperationBody.SetOptionsOp);
    break;
    case OperationType.OperationTypeEnum.CHANGE_TRUST:
    ChangeTrustOp.Encode(stream, encodedOperationBody.ChangeTrustOp);
    break;
    case OperationType.OperationTypeEnum.ALLOW_TRUST:
    AllowTrustOp.Encode(stream, encodedOperationBody.AllowTrustOp);
    break;
    case OperationType.OperationTypeEnum.ACCOUNT_MERGE:
    AccountID.Encode(stream, encodedOperationBody.Destination);
    break;
    case OperationType.OperationTypeEnum.INFLATION:
    break;
    case OperationType.OperationTypeEnum.MANAGE_DATA:
    ManageDataOp.Encode(stream, encodedOperationBody.ManageDataOp);
    break;
    }
    }
    public static OperationBody Decode(IByteReader stream) {
      OperationBody decodedOperationBody = new OperationBody();
    decodedOperationBody.Discriminant = OperationType.Decode(stream);
    switch (decodedOperationBody.Discriminant.InnerValue) {
    case OperationType.OperationTypeEnum.CREATE_ACCOUNT:
    decodedOperationBody.CreateAccountOp = CreateAccountOp.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.PAYMENT:
    decodedOperationBody.PaymentOp = PaymentOp.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.PATH_PAYMENT:
    decodedOperationBody.PathPaymentOp = PathPaymentOp.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.MANAGE_OFFER:
    decodedOperationBody.ManageOfferOp = ManageOfferOp.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.CREATE_PASSIVE_OFFER:
    decodedOperationBody.CreatePassiveOfferOp = CreatePassiveOfferOp.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.SET_OPTIONS:
    decodedOperationBody.SetOptionsOp = SetOptionsOp.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.CHANGE_TRUST:
    decodedOperationBody.ChangeTrustOp = ChangeTrustOp.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.ALLOW_TRUST:
    decodedOperationBody.AllowTrustOp = AllowTrustOp.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.ACCOUNT_MERGE:
    decodedOperationBody.Destination = AccountID.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.INFLATION:
    break;
    case OperationType.OperationTypeEnum.MANAGE_DATA:
    decodedOperationBody.ManageDataOp = ManageDataOp.Decode(stream);
    break;
    }
      return decodedOperationBody;
    }

  }
}
}
