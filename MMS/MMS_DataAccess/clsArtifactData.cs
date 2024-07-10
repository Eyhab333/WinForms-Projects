using System;
using System.Data;
using System.Data.SqlClient;

namespace MMS_DataAccess
{
    public class clsArtifactData
    {
        public static bool GetArtifactInfoByID(
            int HistoricalpieceID,
ref int DivisionID,
ref string PieceName,
ref string PieceDescription,
ref int PieceMaterialID,
ref DateTime DiscoveringDate,
ref string PieceEra,
ref int PieceDimensionsID,
ref int PieceSourceID,
ref string PieceStatusWhenReceived,
ref DateTime ReceivedDate,
ref string ImagePathe,
ref int EnteredByUserID,
ref DateTime EnteringInfoDate,
ref string AdditionalNotes,
ref int HistoricalpieceDocumentationID

            )
        {
            bool isFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM HistoricalPieces WHERE HistoricalpieceID = @HistoricalpieceID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HistoricalpieceID", HistoricalpieceID);

            


            return isFound;
        }

    }
}
