namespace CleanArchitectureCQRs.Domain.Common;

public record Error(string Code, string Message = "");