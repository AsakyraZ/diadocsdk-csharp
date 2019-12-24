﻿using System.Net;
using Diadoc.Api.Http;
using Diadoc.Api.Proto.Events;

namespace Diadoc.Api
{
	public partial class DiadocHttpApi
	{
		public BoxEventList GetNewEvents(string authToken, string boxId, string afterEventId = null)
		{
			var qsb = new PathAndQueryBuilder("/V6/GetNewEvents");
			qsb.AddParameter("includeDrafts");
			qsb.AddParameter("boxId", boxId);
			if (!string.IsNullOrEmpty(afterEventId))
				qsb.AddParameter("afterEventId", afterEventId);
			return PerformHttpRequest<BoxEventList>(authToken, "GET", qsb.BuildPathAndQuery());
		}

		public BoxEvent GetEvent(string authToken, string boxId, string eventId)
		{
			var queryString = string.Format("/V2/GetEvent?eventId={0}&boxId={1}", eventId, boxId);
			return PerformHttpRequest<BoxEvent>(authToken, "GET", queryString);
		}

		public Message GetMessage(string authToken, string boxId, string messageId, bool withOriginalSignature = false, bool injectEntityContent = false)
		{
			var qsb = new PathAndQueryBuilder("/V5/GetMessage");
			qsb.AddParameter("boxId", boxId);
			qsb.AddParameter("messageId", messageId);
			if (withOriginalSignature)
				qsb.AddParameter("originalSignature");
			qsb.AddParameter("injectEntityContent", injectEntityContent.ToString());
			return PerformHttpRequest<Message>(authToken, "GET", qsb.BuildPathAndQuery());
		}

		public Message GetMessage(
			string authToken,
			string boxId,
			string messageId,
			string entityId,
			bool withOriginalSignature = false,
			bool injectEntityContent = false)
		{
			var qsb = new PathAndQueryBuilder("/V5/GetMessage");
			qsb.AddParameter("boxId", boxId);
			qsb.AddParameter("messageId", messageId);
			qsb.AddParameter("entityId", entityId);
			if (withOriginalSignature)
				qsb.AddParameter("originalSignature");
			qsb.AddParameter("injectEntityContent", injectEntityContent.ToString());
			return PerformHttpRequest<Message>(authToken, "GET", qsb.BuildPathAndQuery());
		}

		public Template GetTemplate(string authToken, string boxId, string templateId, string entityId = null)
		{
			var qsb = new PathAndQueryBuilder("/GetTemplate");
			qsb.AddParameter("boxId", boxId);
			qsb.AddParameter("templateId", templateId);
			qsb.AddParameter("entityId", entityId);

			return PerformHttpRequest<Template>(authToken, "GET", qsb.BuildPathAndQuery());
		}

		public byte[] GetEntityContent(string authToken, string boxId, string messageId, string entityId)
		{
			var queryString = string.Format("/V4/GetEntityContent?boxId={0}&messageId={1}&entityId={2}", boxId, messageId, entityId);
			return PerformHttpRequest(authToken, "GET", queryString);
		}

		public Message PostMessage(string authToken, MessageToPost msg, string operationId = null)
		{
			var queryString = string.Format("/V3/PostMessage?operationId={0}", operationId);
			return PerformHttpRequest<MessageToPost, Message>(authToken, queryString, msg);
		}

		public Template PostTemplate(string authToken, TemplateToPost template, string operationId = null)
		{
			var queryString = string.Format("/PostTemplate?operationId={0}", operationId);
			return PerformHttpRequest<TemplateToPost, Template>(authToken, queryString, template);
		}

		public Message TransformTemplateToMessage(string authToken, TemplateTransformationToPost templateTransformation, string operationId = null)
		{
			var qsb = new PathAndQueryBuilder("/TransformTemplateToMessage");
			qsb.AddParameter("operationId", operationId);

			return PerformHttpRequest<TemplateTransformationToPost, Message>(authToken, qsb.BuildPathAndQuery(), templateTransformation);
		}

		public MessagePatch PostMessagePatch(string authToken, MessagePatchToPost patch, string operationId = null)
		{
			var qsb = new PathAndQueryBuilder("/V3/PostMessagePatch");
			qsb.AddParameter("operationId", operationId);
			return PerformHttpRequest<MessagePatchToPost, MessagePatch>(authToken, qsb.BuildPathAndQuery(), patch);
		}

		public MessagePatch PostTemplatePatch(
			string authToken,
			string boxId,
			string templateId,
			TemplatePatchToPost patch,
			string operationId = null)
		{
			var qsb = new PathAndQueryBuilder("/PostTemplatePatch");
			qsb.AddParameter("boxId", boxId);
			qsb.AddParameter("templateId", templateId);
			qsb.AddParameter("operationId", operationId);
			return PerformHttpRequest<TemplatePatchToPost, MessagePatch>(authToken, qsb.BuildPathAndQuery(), patch);
		}

		public void PostRoamingNotification(string authToken, RoamingNotificationToPost notification)
		{
			PerformHttpRequest(authToken, "POST", "/PostRoamingNotification", Serialize(notification));
		}

		public PrepareDocumentsToSignResponse PrepareDocumentsToSign(string authToken, PrepareDocumentsToSignRequest request, bool excludeContent = false)
		{
			var queryString = "/PrepareDocumentsToSign" + (excludeContent ? "?excludeContent" : "");
			return PerformHttpRequest<PrepareDocumentsToSignRequest, PrepareDocumentsToSignResponse>(authToken, queryString, request);
		}

		public BoxEvent GetLastEvent(string authToken, string boxId)
		{
			var queryString = BuildQueryStringWithBoxId("GetLastEvent", boxId);
			return PerformHttpRequest<BoxEvent>(authToken, "GET", queryString, allowedStatusCodes: HttpStatusCode.NoContent);
		}
	}
}