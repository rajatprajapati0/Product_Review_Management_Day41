using System.Data;

namespace Product_Review_Management
{
    public class MDataTable
    {
        public DataTable dataTable;
        public MDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ProductId");
            dataTable.Columns.Add("UserId");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike");
            foreach (var productReview in Program.productReviews)
            {
                dataTable.Rows.Add(productReview.ProductId, productReview.UserId, productReview.Rating, productReview.Review, productReview.isLike);

            }

        }
    }
}