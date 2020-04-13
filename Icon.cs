using Godot;
using System;
using Newtonsoft.Json;
using Ink.Runtime;

public class Icon : Sprite
{
    public override void _Ready()
    {
        GD.Print("Hello from C#");

        DemoClass demo = new DemoClass()
        {
            FirstName = "David",
            LastName = "Wesst"
        };
        string json = JsonConvert.SerializeObject(demo, Formatting.Indented);

        GD.Print(json);

        var storyFile = new File();
        storyFile.Open("res://ink/test.ink.json", File.ModeFlags.Read);
        var storyData = storyFile.GetAsText();
        storyFile.Close();

        Story story = new Story(storyData);
        GD.Print(story.Continue());
    }
}
