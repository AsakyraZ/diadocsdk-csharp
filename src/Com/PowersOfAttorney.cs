﻿using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Diadoc.Api.Com;

namespace Diadoc.Api.Proto.PowersOfAttorney
{
	[ComVisible(true)]
	[Guid("8CAE7E41-5306-431E-A9F3-37211755FCBE")]
	public interface IPowerOfAttorneyFullId
	{
		string RegistrationNumber { get; set; }
		string IssuerInn { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyFullId")]
	[Guid("5B40AE3C-0054-4791-9BB9-E0056DFD325A")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyFullId))]
	public partial class PowerOfAttorneyFullId : SafeComObject, IPowerOfAttorneyFullId
	{
	}

	[ComVisible(true)]
	[Guid("8693BD64-97CF-41F1-A478-9A1CA417574C")]
	public interface IPowerOfAttorney
	{
		PowerOfAttorneyFullId FullId { get; set; }
		PowerOfAttorneyIssuer Issuer { get; set; }
		PowerOfAttorneyConfidant Confidant { get; set; }
		Timestamp StartAt { get; set; }
		Timestamp ExpireAt { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorney")]
	[Guid("5415CFFF-140C-4AFB-A9A5-E7D8E9A1A420")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorney))]
	public partial class PowerOfAttorney : SafeComObject, IPowerOfAttorney
	{
	}

	[ComVisible(true)]
	[Guid("55DFF897-C2FE-4A71-ADC2-7907C2190750")]
	public interface IPowerOfAttorneyIssuer
	{
		Com.PowerOfAttorneyIssuerType Type { get; set; }
		PowerOfAttorneyIssuerLegalEntity LegalEntity { get; set; }
		PowerOfAttorneyIssuerForeignEntity ForeignEntity { get; set; }
		PowerOfAttorneyIssuerIndividualEntity IndividualEntity { get; set; }
		PowerOfAttorneyIssuerPhysicalEntity PhysicalEntity { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyIssuer")]
	[Guid("BAD272F1-BC98-4CFE-9350-24ACBB1A0BBC")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyIssuer))]
	public partial class PowerOfAttorneyIssuer : SafeComObject, IPowerOfAttorneyIssuer
	{
		Com.PowerOfAttorneyIssuerType IPowerOfAttorneyIssuer.Type
		{
			get { return (Com.PowerOfAttorneyIssuerType) Type; }
			set { Type = (PowerOfAttorneyIssuerType) value; }
		}
	}

	[ComVisible(true)]
	[Guid("0707D3F6-EAEC-40D0-BC82-38E538D6DD2A")]
	public interface IPowerOfAttorneyIssuerLegalEntity
	{
		string Inn { get; set; }
		string Kpp { get; set; }
		string OrganizationName { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyIssuerLegalEntity")]
	[Guid("4096059F-021E-4D85-8D2D-E0EA00F82C78")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyIssuerLegalEntity))]
	public partial class PowerOfAttorneyIssuerLegalEntity : SafeComObject, IPowerOfAttorneyIssuerLegalEntity
	{
	}

	[ComVisible(true)]
	[Guid("8E935CF8-8276-4120-A188-86ACFB90584F")]
	public interface IPowerOfAttorneyIssuerForeignEntity
	{
		string Inn { get; set; }
		string Kpp { get; set; }
		string OrganizationName { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyIssuerForeignEntity")]
	[Guid("14950451-63B6-4632-BCB2-6ED7FF5131F3")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyIssuerForeignEntity))]
	public partial class PowerOfAttorneyIssuerForeignEntity : SafeComObject, IPowerOfAttorneyIssuerForeignEntity
	{
	}

	[ComVisible(true)]
	[Guid("F7D5AF94-80FB-4543-978D-E91A313CDDA1")]
	public interface IPowerOfAttorneyIssuerIndividualEntity
	{
		string Inn { get; set; }
		string OrganizationName { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyIssuerIndividualEntity")]
	[Guid("4A6A0D66-E1B3-40F1-976E-20AD7B0584A8")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyIssuerIndividualEntity))]
	public partial class PowerOfAttorneyIssuerIndividualEntity : SafeComObject, IPowerOfAttorneyIssuerIndividualEntity
	{
	}

	[ComVisible(true)]
	[Guid("26D685B7-E031-40FD-A1D3-69BB9C5E5F17")]
	public interface IPowerOfAttorneyIssuerPhysicalEntity
	{
		string Inn { get; set; }
		FullName PersonName { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyIssuerPhysicalEntity")]
	[Guid("59E1AEFB-A762-4231-A1E5-F7FF0B6ABB81")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyIssuerPhysicalEntity))]
	public partial class PowerOfAttorneyIssuerPhysicalEntity : SafeComObject, IPowerOfAttorneyIssuerPhysicalEntity
	{
	}

	[ComVisible(true)]
	[Guid("6C0B0D18-E6DA-4D3A-A0B3-68DFC222E8C8")]
	public interface IPowerOfAttorneyConfidant
	{
		FullName PersonName { get; set; }
		string Inn { get; set; }
		PowerOfAttorneyConfidantOrganization Organization { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyConfidant")]
	[Guid("BC1CE6C1-C213-48EE-839C-F6D1A6C1DCB5")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyConfidant))]
	public partial class PowerOfAttorneyConfidant : SafeComObject, IPowerOfAttorneyConfidant
	{
	}

	[ComVisible(true)]
	[Guid("E6EAA9F9-2EB1-4093-9952-954885430C43")]
	public interface IPowerOfAttorneyConfidantOrganization
	{
		string Inn { get; set; }
		string Kpp { get; set; }
		string Name { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyConfidantOrganization")]
	[Guid("29DFCDC1-4847-4245-93E0-4AEE2CFDF05A")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyConfidantOrganization))]
	public partial class PowerOfAttorneyConfidantOrganization : SafeComObject, IPowerOfAttorneyConfidantOrganization
	{
	}

	[ComVisible(true)]
	[Guid("C1779391-DABC-4724-8FBC-48ECA36B0993")]
	public interface IPowerOfAttorneyPrevalidateRequest
	{
		ConfidantCertificateToPrevalidate ConfidantCertificate { get; set; }
		void SetConfidantCertificate([MarshalAs(UnmanagedType.IDispatch)] object confidantCertificate);
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyPrevalidateRequest")]
	[Guid("835617CD-48C4-49C2-8B39-8D7F64B3BF49")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyPrevalidateRequest))]
	public partial class PowerOfAttorneyPrevalidateRequest : SafeComObject, IPowerOfAttorneyPrevalidateRequest
	{
		public void SetConfidantCertificate(object confidantCertificate)
		{
			ConfidantCertificate = (ConfidantCertificateToPrevalidate) confidantCertificate;
		}
	}

	[ComVisible(true)]
	[Guid("4BB1DB4A-957D-4473-87AE-394A020E1153")]
	public interface IConfidantCertificateToPrevalidate
	{
		string Thumbprint { get; set; }
		Content_v3 Content { get; set; }

		void SetContent([MarshalAs(UnmanagedType.IDispatch)] object content);
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.ConfidantCertificateToPrevalidate")]
	[Guid("85ED5BA5-F88C-487F-A9BC-0F50B1702D29")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IConfidantCertificateToPrevalidate))]
	public partial class ConfidantCertificateToPrevalidate : SafeComObject, IConfidantCertificateToPrevalidate
	{
		public void SetContent(object content)
		{
			Content = (Content_v3) content;
		}
	}

	[ComVisible(true)]
	[Guid("C32C2057-2EE8-4813-91C1-31787AD54C07")]
	public interface IPowerOfAttorneyPrevalidateResult
	{
		PowerOfAttorneyValidationStatus PrevalidateStatus { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyPrevalidateResult")]
	[Guid("38CB9559-81F3-4AA8-8A72-941DBA5836A4")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyPrevalidateResult))]
	public partial class PowerOfAttorneyPrevalidateResult : SafeComObject, IPowerOfAttorneyPrevalidateResult
	{
	}

	[ComVisible(true)]
	[Guid("26B870BC-D36B-4CA2-8C5B-903DE398CD28")]
	public interface IPowerOfAttorneyValidationStatus
	{
		Com.Severity Severity { get; }
		Com.PowerOfAttorneyValidationStatusNamedId StatusNamedId { get; }
		string StatusText { get; }
		ReadonlyList ErrorsList { get; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyValidationStatus")]
	[Guid("FC779ADD-A511-4AA0-B911-F4803554562B")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyValidationStatus))]
	public partial class PowerOfAttorneyValidationStatus : SafeComObject, IPowerOfAttorneyValidationStatus
	{
		Com.Severity IPowerOfAttorneyValidationStatus.Severity
		{
			get { return (Com.Severity) Severity; }
		}

		Com.PowerOfAttorneyValidationStatusNamedId IPowerOfAttorneyValidationStatus.StatusNamedId
		{
			get { return (Com.PowerOfAttorneyValidationStatusNamedId) StatusNamedId; }
		}

		public ReadonlyList ErrorsList
		{
			get { return new ReadonlyList(Errors); }
		}
	}

	[ComVisible(true)]
	[Guid("DEF90B88-40A7-4EA1-81CD-30D60F3F99FD")]
	public interface IPowerOfAttorneyValidationError
	{
		string Code { get; set; }
		string Text { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyValidationError")]
	[Guid("91FAF81E-AC57-4D32-B91B-CE45F328DF6B")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyValidationError))]
	public partial class PowerOfAttorneyValidationError : SafeComObject, IPowerOfAttorneyValidationError
	{
	}

	[ComVisible(true)]
	[Guid("8A664FAC-D82E-4E4A-8DC4-AA8C16D0763A")]
	public interface IPowerOfAttorneyToRegister
	{
		PowerOfAttorneyFullId FullId { get; set; }
		PowerOfAttorneySignedContent Content { get; set; }

		void SetFullId([MarshalAs(UnmanagedType.IDispatch)] object fullId);
		void SetContent([MarshalAs(UnmanagedType.IDispatch)] object content);
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyToRegister")]
	[Guid("76417A13-5B84-4EDC-933A-330B042B84B3")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyToRegister))]
	public partial class PowerOfAttorneyToRegister : SafeComObject, IPowerOfAttorneyToRegister
	{
		public void SetFullId(object fullId)
		{
			FullId = (PowerOfAttorneyFullId) fullId;
		}

		public void SetContent(object content)
		{
			Content = (PowerOfAttorneySignedContent) content;
		}
	}

	[ComVisible(true)]
	[Guid("E3C5A91B-2552-433F-B095-5D97D784B404")]
	public interface IPowerOfAttorneySignedContent
	{
		Content_v3 Content { get; set; }
		Content_v3 Signature { get; set; }

		void SetContent([MarshalAs(UnmanagedType.IDispatch)] object content);
		void SetSignature([MarshalAs(UnmanagedType.IDispatch)] object signature);
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneySignedContent")]
	[Guid("4DE57BCF-6375-41B0-9DD7-BFD86565779C")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneySignedContent))]
	public partial class PowerOfAttorneySignedContent : SafeComObject, IPowerOfAttorneySignedContent
	{
		public void SetContent(object content)
		{
			Content = (Content_v3) content;
		}

		public void SetSignature(object signature)
		{
			Signature = (Content_v3) signature;
		}
	}

	[ComVisible(true)]
	[Guid("6209DE7D-5B43-4F92-8F78-E24AD9E0E256")]
	public interface IPowerOfAttorneyRegisterResult
	{
		string OperationStatus { get; set; }
		PowerOfAttorney PowerOfAttorney { get; set; }
		PowerOfAttorneyStatus Status { get; set; }
		ReadonlyList ErrorsList { get; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyRegisterResult")]
	[Guid("9FCCF5C3-4A6B-4112-9B40-1FABD01E950B")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyRegisterResult))]
	public partial class PowerOfAttorneyRegisterResult : SafeComObject, IPowerOfAttorneyRegisterResult
	{
		public ReadonlyList ErrorsList
		{
			get { return new ReadonlyList(Errors); }
		}
	}

	[ComVisible(true)]
	[Guid("A0CF70AF-67F4-4B39-B058-956F2BAE5E27")]
	public interface IPowerOfAttorneyStatus
	{
		string Status { get; set; }
		Timestamp LastCheckAt { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyStatus")]
	[Guid("AAF34E07-2D02-44E5-A574-459A44060C28")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyStatus))]
	public partial class PowerOfAttorneyStatus : SafeComObject, IPowerOfAttorneyStatus
	{
	}

	[ComVisible(true)]
	[Guid("2178772B-F170-4CAE-872A-7F1A8DD0B8EC")]
	public interface IPowerOfAttorneyOperationError
	{
		string Code { get; set; }
		string Text { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.PowerOfAttorneyOperationError")]
	[Guid("E9C82338-7F45-46AD-BD97-BC7B45744E46")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IPowerOfAttorneyOperationError))]
	public partial class PowerOfAttorneyOperationError : SafeComObject, IPowerOfAttorneyOperationError
	{
	}
}

namespace Diadoc.Api.Com
{
	[ComVisible(true)]
	[Guid("DAC091ED-7B0B-4E77-B1A7-3FF97914BA47")]
	//NOTE: Это хотели, чтобы можно было использовать XML-сериализацию для классов
	[XmlType(TypeName = "PowerOfAttorneyIssuerType", Namespace = "https://diadoc-api.kontur.ru")]
	public enum PowerOfAttorneyIssuerType
	{
		UnknownIssuerType = 0,
		LegalEntity = 1,
		ForeignEntity = 2,
		IndividualEntity = 3,
		PhysicalEntity = 4
	}

	[ComVisible(true)]
	[Guid("FF262C58-A262-480B-B928-BE3BDCEE5D8B")]
	//NOTE: Это хотели, чтобы можно было использовать XML-сериализацию для классов
	[XmlType(TypeName = "PowerOfAttorneyValidationStatusNamedId", Namespace = "https://diadoc-api.kontur.ru")]
	public enum PowerOfAttorneyValidationStatusNamedId
	{
		UnknownStatus = 0,
		CanNotBeValidated = 1,
		IsValid = 2,
		IsNotValid = 3,
		ValidationError = 4
	}
}
