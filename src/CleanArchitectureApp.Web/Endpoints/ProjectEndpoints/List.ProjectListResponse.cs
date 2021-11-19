using CleanArchitectureApp.Core.ProjectAggregate;
using System.Collections.Generic;

namespace CleanArchitectureApp.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
