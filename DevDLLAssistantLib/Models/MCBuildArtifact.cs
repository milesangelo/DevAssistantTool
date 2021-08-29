using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAssistant.Logic.Models
{
    public enum ArtifactType 
    {
        DLL = 0,
        PDB
    };

    public class MCBuildArtifact
    {
        public string FileName { get; set; }
        
        public string FullPath { get; set; }

        public DateTime LastModified { get; set; }

        public ArtifactType ArtifactType { get; set; }
    }
}
