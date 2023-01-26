using Volo.Abp.Application.Dtos;

namespace ABPEcommerce.Admin
{
    public class BaseListFilterDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}