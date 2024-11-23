using System;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Interface;

public interface IDocumentService
{
   Task<string> UploadDocumentAsync(DocumentModel document);
    Task<DocumentModel> GetDocumentAsync(int documentId);
    Task<bool> ManageVersionsAsync(int documentId, List<string> versions);
}
