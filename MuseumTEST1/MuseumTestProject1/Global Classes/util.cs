using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumTestProject1.Global_Classes
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            string DestinationFolder = @"C:\DVLD-People-Images\";
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
    }
}

/*
Kotlin
 
import java.io.File
import java.nio.file.Files
import java.nio.file.Paths
import javax.swing.JOptionPane

object clsUtil {
    fun generateGUID(): String {
        // Generate a new UUID
        val newUuid = java.util.UUID.randomUUID()
        // Convert the UUID to a string
        return newUuid.toString()
    }

    fun createFolderIfDoesNotExist(folderPath: String): Boolean {
        // Check if the folder exists
        if (!Files.exists(Paths.get(folderPath))) {
            try {
                // If it doesn't exist, create the folder
                Files.createDirectories(Paths.get(folderPath))
                return true
            } catch (ex: Exception) {
                JOptionPane.showMessageDialog(null, "Error creating folder: ${ex.message}")
                return false
            }
        }
        return true
    }
}


Swift

import Foundation

class clsUtil {
    static func generateGUID() -> String {
        // Generate a new UUID
        let newUUID = UUID()
        // Convert the UUID to a string
        return newUUID.uuidString
    }
    
    @discardableResult
    static func createFolderIfDoesNotExist(folderPath: String) -> Bool {
        let fileManager = FileManager.default
        // Check if the folder exists
        if !fileManager.fileExists(atPath: folderPath) {
            do {
                // If it doesn't exist, create the folder
                try fileManager.createDirectory(atPath: folderPath, withIntermediateDirectories: true, attributes: nil)
                return true
            } catch {
                print("Error creating folder: \(error.localizedDescription)")
                return false
            }
        }
        return true
    }
}


dart

import 'dart:io';

class ClsUtil {
  static String generateGUID() {
    // Generate a new UUID
    return UniqueKey().toString();
  }

  static bool createFolderIfDoesNotExist(String folderPath) {
    final directory = Directory(folderPath);
    // Check if the folder exists
    if (!directory.existsSync()) {
      try {
        // If it doesn't exist, create the folder
        directory.createSync(recursive: true);
        return true;
      } catch (e) {
        print("Error creating folder: $e");
        return false;
      }
    }
    return true;
  }
}


 */