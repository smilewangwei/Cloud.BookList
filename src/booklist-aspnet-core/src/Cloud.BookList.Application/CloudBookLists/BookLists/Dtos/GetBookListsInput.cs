using Abp.Runtime.Validation;
using Cloud.BookList.Dtos;

namespace Cloud.BookList.CloudBookLists.BookLists.Dtos
{
    public class GetBookListsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
