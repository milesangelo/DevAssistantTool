using DevAssistant.Logic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevAssistant.Logic.Services
{
    public interface IDevAssistantService
    {
        Task<List<MCBuildArtifact>> GetAvailableArtifacts();
    }
}
