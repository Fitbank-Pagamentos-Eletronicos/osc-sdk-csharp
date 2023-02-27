using osc_sdk_csharp.src.Enums;

namespace osc_sdk_csharp.src.Models.Responses;

public record DocumentResponse(DocumentType Type, MimeType MimeType, string Name, string URL);