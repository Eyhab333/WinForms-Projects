using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum_DataAccessLayer.HistoricalPieces
{
    public class clsHistoricalPiecesDataAccess
    {


        public static DataTable GetAllHistoricalPieces()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
              @"

SELECT        HistoricalPieces.HistoricalpieceID, HistoricalPieces.PieceName, HistoricalPieces.PieceDescription, Divisions.DivisionName, HistoricalPieces.PieceMaterial, HistoricalPieces.PieceMaterialProperties, 
                         HistoricalPieces.DiscoveringDate, HistoricalPieces.PieceEra, PieceDimensions.length, PieceDimensions.Width, PieceDimensions.Height, PieceDimensions.Weight, PieceSources.PieceSource, 
                         HistoricalPieces.PieceStatusWhenReceived, HistoricalPieces.ReceivedDate, ImagesPathes.ImagePath1, Users.UserName, HistoricalPieces.EnteringInfoDate, HistoricalPieces.AdditionalNotes, 
                         DocumentationAndRegistrationInDetailes.BorrowingType, DocumentationAndRegistrationInDetailes.ReceivedDate AS Expr1, DocumentationAndRegistrationInDetailes.GroupNumber, 
                         DocumentationAndRegistrationInDetailes.PieceOrderInTheGroup, DocumentationAndRegistrationInDetailes.PartOrderInThePiece
FROM            HistoricalPieces INNER JOIN
                         Divisions ON HistoricalPieces.DivisionID = Divisions.DivisionID INNER JOIN
                         DocumentationAndRegistrationInDetailes ON HistoricalPieces.HistoricalpieceDocumentationID = DocumentationAndRegistrationInDetailes.HestoricalPieceDOCSid INNER JOIN
                         ImagesPathes ON HistoricalPieces.ImagesPathesID = ImagesPathes.ImagePathID INNER JOIN
                         PieceDimensions ON HistoricalPieces.PieceDimensionsID = PieceDimensions.PieceDimensionsID INNER JOIN
                         PieceSources ON HistoricalPieces.PieceSourceID = PieceSources.PieceSourceID INNER JOIN
                         Users ON HistoricalPieces.EnteredByUserID = Users.UserID INNER JOIN
                         People ON Users.PersonID = People.PersonID


";




            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
    }
}
