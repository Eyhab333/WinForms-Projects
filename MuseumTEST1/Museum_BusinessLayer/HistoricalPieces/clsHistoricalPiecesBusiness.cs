using Museum_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum_DataAccessLayer.HistoricalPieces;

namespace Museum_BusinessLayer.HistoricalPieces
{
    public class clsHistoricalPiecesBusiness
    {
        //public enum enMode { AddNew = 0, Update = 1 };
        //public enMode Mode = enMode.AddNew;

        //public int HistoricalpieceID { get; set; }
        //public string PieceName { get; set; }   
        //public string PieceDescription { get; set; }   
        //public string PieceMaterial { get; set; }   
        //public string PieceMaterialProperties { get; set; }   
        //public string DiscoveringDate { get; set; }   
        //public string PieceEra { get; set; }   
        //public string PieceStatusWhenReceived { get; set; }   
        //public string ReceivedDate { get; set; }   
        //public string EnteringInfoDate { get; set; }   
        //public string AdditionalNotes { get; set; } 
        

        //public int DivisionID { get; set; }
        //public int PieceDimensionsID { get; set; }
        //public int PieceSourceID { get; set; }
        //public int ImagesPathesID { get; set; }
        //public int EnteredByUserID { get; set; }
        //public int HistoricalpieceDocumentationID { get; set; }




        public static DataTable GetAllHistoricalPieces()
        {
            return clsHistoricalPiecesDataAccess.GetAllHistoricalPieces();
        }
    }
}
