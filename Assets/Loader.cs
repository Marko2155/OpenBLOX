using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using SFB;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NativeMessageBox : MonoBehaviour
{
    // Windows-specific method
    #if UNITY_STANDALONE_WIN
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int MessageBox(int hWnd, string text, string caption, int options);
    #endif

    public static void ShowMessageBox(string message, string title)
    {
        #if UNITY_STANDALONE_WIN
        // Show native Windows message box
        MessageBox(0, message, title, 0x00000000);
        #elif UNITY_STANDALONE_OSX
        // Show native macOS dialog box using osascript
        string appleScript = $"tell application \"System Events\" to display dialog \"{message}\" with title \"{title}\" buttons {{\"OK\"}}";
        System.Diagnostics.Process.Start("osascript", $"-e \"{appleScript}\"");
        #elif UNITY_STANDALONE_LINUX
        // Show native Linux dialog box using Zenity
        System.Diagnostics.Process.Start("zenity", $"--info --text=\"{message}\" --title=\"{title}\"");
        #endif
    }
}

public class Loader : MonoBehaviour
{
    string RBXLpath = "";
    public Text RBXLPathText;

    void Update() {
        if (RBXLpath.Length != 0) {
            RBXLPathText.text = "Selected RBXL: " + RBXLpath;
        }
    }

    public void LoadRBXL() {
        if (!string.IsNullOrEmpty(RBXLpath)) {
            PlayerPrefs.SetString("RBXLpath", RBXLpath);
            SceneManager.LoadScene("RBXLStart");
        } else {
            NativeMessageBox.ShowMessageBox("No RBXL selected", "Error");
        }
    }

    public void SetRBXLPath() {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select RBXL", "", "rbxl", false);
        Debug.Log(paths[0]);
        RBXLpath = paths[0];
    }

}
