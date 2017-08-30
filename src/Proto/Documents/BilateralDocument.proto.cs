//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Documents/BilateralDocument.proto
// Note: requires additional types generated from: Documents/ReceiptStatus.proto
namespace Diadoc.Api.Proto.Documents.BilateralDocument
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TrustConnectionRequestMetadata")]
  public partial class TrustConnectionRequestMetadata : global::ProtoBuf.IExtensible
  {
    public TrustConnectionRequestMetadata() {}
    

    private Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus _TrustConnectionRequestStatus = Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"TrustConnectionRequestStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus)]
    public Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus TrustConnectionRequestStatus
    {
      get { return _TrustConnectionRequestStatus; }
      set { _TrustConnectionRequestStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicDocumentMetadata")]
  public partial class BasicDocumentMetadata : global::ProtoBuf.IExtensible
  {
    public BasicDocumentMetadata() {}
    

    private Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus _DocumentStatus = Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus)]
    public Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus DocumentStatus
    {
      get { return _DocumentStatus; }
      set { _DocumentStatus = value; }
    }
    private string _Total;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }

    private string _Vat = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }

    private string _Grounds = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Grounds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Grounds
    {
      get { return _Grounds; }
      set { _Grounds = value; }
    }

    private Diadoc.Api.Proto.Documents.ReceiptStatus _ReceiptStatus = Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ReceiptStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus)]
    public Diadoc.Api.Proto.Documents.ReceiptStatus ReceiptStatus
    {
      get { return _ReceiptStatus; }
      set { _ReceiptStatus = value; }
    }

    private string _RevisionDate = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"RevisionDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string RevisionDate
    {
      get { return _RevisionDate; }
      set { _RevisionDate = value; }
    }

    private string _RevisionNumber = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"RevisionNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string RevisionNumber
    {
      get { return _RevisionNumber; }
      set { _RevisionNumber = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PriceListMetadata")]
  public partial class PriceListMetadata : global::ProtoBuf.IExtensible
  {
    public PriceListMetadata() {}
    

    private Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus _DocumentStatus = Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus)]
    public Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus DocumentStatus
    {
      get { return _DocumentStatus; }
      set { _DocumentStatus = value; }
    }

    private string _PriceListEffectiveDate = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PriceListEffectiveDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string PriceListEffectiveDate
    {
      get { return _PriceListEffectiveDate; }
      set { _PriceListEffectiveDate = value; }
    }

    private string _ContractDocumentDate = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ContractDocumentDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractDocumentDate
    {
      get { return _ContractDocumentDate; }
      set { _ContractDocumentDate = value; }
    }

    private string _ContractDocumentNumber = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ContractDocumentNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractDocumentNumber
    {
      get { return _ContractDocumentNumber; }
      set { _ContractDocumentNumber = value; }
    }

    private Diadoc.Api.Proto.Documents.ReceiptStatus _ReceiptStatus = Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ReceiptStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus)]
    public Diadoc.Api.Proto.Documents.ReceiptStatus ReceiptStatus
    {
      get { return _ReceiptStatus; }
      set { _ReceiptStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ContractMetadata")]
  public partial class ContractMetadata : global::ProtoBuf.IExtensible
  {
    public ContractMetadata() {}
    

    private Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus _DocumentStatus = Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus)]
    public Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus DocumentStatus
    {
      get { return _DocumentStatus; }
      set { _DocumentStatus = value; }
    }

    private string _ContractPrice = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ContractPrice", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractPrice
    {
      get { return _ContractPrice; }
      set { _ContractPrice = value; }
    }

    private string _ContractType = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ContractType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractType
    {
      get { return _ContractType; }
      set { _ContractType = value; }
    }

    private Diadoc.Api.Proto.Documents.ReceiptStatus _ReceiptStatus = Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ReceiptStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus)]
    public Diadoc.Api.Proto.Documents.ReceiptStatus ReceiptStatus
    {
      get { return _ReceiptStatus; }
      set { _ReceiptStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SupplementaryAgreementMetadata")]
  public partial class SupplementaryAgreementMetadata : global::ProtoBuf.IExtensible
  {
    public SupplementaryAgreementMetadata() {}
    

    private Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus _DocumentStatus = Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus)]
    public Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus DocumentStatus
    {
      get { return _DocumentStatus; }
      set { _DocumentStatus = value; }
    }

    private string _Total = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }

    private string _ContractType = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ContractType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractType
    {
      get { return _ContractType; }
      set { _ContractType = value; }
    }
    private string _ContractNumber;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ContractNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ContractNumber
    {
      get { return _ContractNumber; }
      set { _ContractNumber = value; }
    }
    private string _ContractDate;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ContractDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ContractDate
    {
      get { return _ContractDate; }
      set { _ContractDate = value; }
    }

    private Diadoc.Api.Proto.Documents.ReceiptStatus _ReceiptStatus = Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ReceiptStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus)]
    public Diadoc.Api.Proto.Documents.ReceiptStatus ReceiptStatus
    {
      get { return _ReceiptStatus; }
      set { _ReceiptStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BilateralDocumentMetadata")]
  public partial class BilateralDocumentMetadata : global::ProtoBuf.IExtensible
  {
    public BilateralDocumentMetadata() {}
    

    private Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus _DocumentStatus = Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus.UnknownBilateralDocumentStatus)]
    public Diadoc.Api.Proto.Documents.BilateralDocument.BilateralDocumentStatus DocumentStatus
    {
      get { return _DocumentStatus; }
      set { _DocumentStatus = value; }
    }

    private Diadoc.Api.Proto.Documents.ReceiptStatus _ReceiptStatus = Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ReceiptStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus)]
    public Diadoc.Api.Proto.Documents.ReceiptStatus ReceiptStatus
    {
      get { return _ReceiptStatus; }
      set { _ReceiptStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"BilateralDocumentStatus")]
    public enum BilateralDocumentStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UnknownBilateralDocumentStatus", Value=0)]
      UnknownBilateralDocumentStatus = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForRecipientSignature", Value=1)]
      OutboundWaitingForRecipientSignature = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWithRecipientSignature", Value=2)]
      OutboundWithRecipientSignature = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundRecipientSignatureRequestRejected", Value=3)]
      OutboundRecipientSignatureRequestRejected = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForSenderSignature", Value=10)]
      OutboundWaitingForSenderSignature = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundInvalidSenderSignature", Value=11)]
      OutboundInvalidSenderSignature = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWaitingForRecipientSignature", Value=4)]
      InboundWaitingForRecipientSignature = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWithRecipientSignature", Value=5)]
      InboundWithRecipientSignature = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundRecipientSignatureRequestRejected", Value=6)]
      InboundRecipientSignatureRequestRejected = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundInvalidRecipientSignature", Value=12)]
      InboundInvalidRecipientSignature = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWaitingForRecipientSignature", Value=7)]
      InternalWaitingForRecipientSignature = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWithRecipientSignature", Value=8)]
      InternalWithRecipientSignature = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalRecipientSignatureRequestRejected", Value=9)]
      InternalRecipientSignatureRequestRejected = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWaitingForSenderSignature", Value=13)]
      InternalWaitingForSenderSignature = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalInvalidSenderSignature", Value=14)]
      InternalInvalidSenderSignature = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalInvalidRecipientSignature", Value=15)]
      InternalInvalidRecipientSignature = 15
    }
  
}