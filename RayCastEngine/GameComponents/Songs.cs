using System.Threading;

namespace RayCastEngine.GameComponents {
  static class Songs {
    #region Doom Song
    public static void Doom(MidiPlayer player) {
      player.changeController(0, 0, 0); // Change The Controller Properties on Channel 0, set the property to 0
      player.programChange(0, 30); // Change The Instrument On Channel 0, To Instrument At Index 30
      player.changeController(0, 10, 44); // Change The Controller Properties on Channel 10, set the property to 44
      player.changeController(0, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.changeController(1, 0, 0); // Change The Controller Properties on Channel 0, set the property to 0
      player.programChange(1, 30); // Change The Instrument On Channel 1, To Instrument At Index 30
      player.changeController(1, 10, 74); // Change The Controller Properties on Channel 10, set the property to 74
      player.changeController(1, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.changeController(2, 0, 0); // Change The Controller Properties on Channel 0, set the property to 0
      player.programChange(2, 29); // Change The Instrument On Channel 2, To Instrument At Index 29
      player.changeController(2, 10, 44); // Change The Controller Properties on Channel 10, set the property to 44
      player.changeController(2, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(3, 0, 0); // Change The Controller Properties on Channel 0, set the property to 0
      player.programChange(3, 29); // Change The Instrument On Channel 3, To Instrument At Index 29
      player.changeController(3, 10, 74); // Change The Controller Properties on Channel 10, set the property to 74
      player.changeController(3, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(4, 0, 0); // Change The Controller Properties on Channel 0, set the property to 0
      player.programChange(4, 34); // Change The Instrument On Channel 4, To Instrument At Index 34
      player.changeController(4, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.changeController(4, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.changeController(5, 0, 0); // Change The Controller Properties on Channel 0, set the property to 0
      player.programChange(5, 63); // Change The Instrument On Channel 5, To Instrument At Index 63
      player.changeController(5, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.changeController(5, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(9, 0, 0); // Change The Controller Properties on Channel 0, set the property to 0
      player.programChange(9, 0); // Change The Instrument On Channel 9, To Instrument At Index 0
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.changeController(9, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.noteOn(9, 57, 83); // Play The Note 57, at velocity 83 on channel 9
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 40, 112); // Play The Note 40, at velocity 112 on channel 9
      player.noteOn(9, 46, 86); // Play The Note 46, at velocity 86 on channel 9
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(9, 35, 114); // Play The Note 35, at velocity 114 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      player.noteOn(9, 46, 62); // Play The Note 46, at velocity 62 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(9, 35, 110); // Play The Note 35, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 46, 53); // Play The Note 46, at velocity 53 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      player.noteOn(9, 46, 50); // Play The Note 46, at velocity 50 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 46, 53); // Play The Note 46, at velocity 53 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 46, 62); // Play The Note 46, at velocity 62 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(1, 47, 91); // Play The Note 47, at velocity 91 on channel 1
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 91); // Play The Note 40, at velocity 91 on channel 0
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 109); // Play The Note 30, at velocity 109 on channel 4
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 46, 59); // Play The Note 46, at velocity 59 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 43, 94); // Play The Note 43, at velocity 94 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 50, 94); // Play The Note 50, at velocity 94 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 31, 105); // Play The Note 31, at velocity 105 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 53); // Play The Note 46, at velocity 53 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOff(0, 43); // Turn off Note 43, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 31); // Turn off Note 31, on channel 4
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      player.noteOn(9, 46, 53); // Play The Note 46, at velocity 53 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 115); // Play The Note 30, at velocity 115 on channel 4
      player.noteOn(9, 35, 124); // Play The Note 35, at velocity 124 on channel 9
      player.noteOn(9, 57, 80); // Play The Note 57, at velocity 80 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 95); // Play The Note 46, at velocity 95 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 46, 59); // Play The Note 46, at velocity 59 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 91); // Play The Note 40, at velocity 91 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 91); // Play The Note 47, at velocity 91 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 93); // Play The Note 42, at velocity 93 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 93); // Play The Note 49, at velocity 93 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 35, 124); // Play The Note 35, at velocity 124 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 35, 114); // Play The Note 35, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 94); // Play The Note 47, at velocity 94 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 94); // Play The Note 40, at velocity 94 on channel 0
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 94); // Play The Note 28, at velocity 94 on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 110); // Play The Note 30, at velocity 110 on channel 4
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 35, 126); // Play The Note 35, at velocity 126 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 93); // Play The Note 40, at velocity 93 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 93); // Play The Note 47, at velocity 93 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 90); // Play The Note 40, at velocity 90 on channel 0
      player.noteOn(1, 47, 90); // Play The Note 47, at velocity 90 on channel 1
      player.noteOn(4, 28, 97); // Play The Note 28, at velocity 97 on channel 4
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 94); // Play The Note 49, at velocity 94 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 94); // Play The Note 42, at velocity 94 on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(229); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 43, 92); // Play The Note 43, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 50, 92); // Play The Note 50, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 31, 100); // Play The Note 31, at velocity 100 on channel 4
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 49, 94); // Play The Note 49, at velocity 94 on channel 1
      player.noteOff(4, 31); // Turn off Note 31, on channel 4
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 43); // Turn off Note 43, on channel 0
      player.noteOn(0, 42, 94); // Play The Note 42, at velocity 94 on channel 0
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(9, 35, 104); // Play The Note 35, at velocity 104 on channel 9
      player.noteOn(9, 33, 56); // Play The Note 33, at velocity 56 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 33); // Turn off Note 33, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 93); // Play The Note 40, at velocity 93 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 93); // Play The Note 47, at velocity 93 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 93); // Play The Note 42, at velocity 93 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 93); // Play The Note 49, at velocity 93 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 57, 86); // Play The Note 57, at velocity 86 on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 107); // Play The Note 28, at velocity 107 on channel 4
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 114); // Play The Note 35, at velocity 114 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 93); // Play The Note 40, at velocity 93 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 93); // Play The Note 47, at velocity 93 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(1, 47, 91); // Play The Note 47, at velocity 91 on channel 1
      player.noteOn(4, 28, 97); // Play The Note 28, at velocity 97 on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 91); // Play The Note 40, at velocity 91 on channel 0
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 50, 92); // Play The Note 50, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 31, 105); // Play The Note 31, at velocity 105 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 43, 92); // Play The Note 43, at velocity 92 on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 49, 93); // Play The Note 49, at velocity 93 on channel 1
      player.noteOff(4, 31); // Turn off Note 31, on channel 4
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(9, 35, 126); // Play The Note 35, at velocity 126 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 43); // Turn off Note 43, on channel 0
      player.noteOn(0, 42, 93); // Play The Note 42, at velocity 93 on channel 0
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 95); // Play The Note 46, at velocity 95 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 95); // Play The Note 49, at velocity 95 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 57, 89); // Play The Note 57, at velocity 89 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 95); // Play The Note 42, at velocity 95 on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 103); // Play The Note 28, at velocity 103 on channel 4
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 40, 91); // Play The Note 40, at velocity 91 on channel 0
      player.noteOn(1, 47, 91); // Play The Note 47, at velocity 91 on channel 1
      player.noteOn(4, 28, 98); // Play The Note 28, at velocity 98 on channel 4
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 126); // Play The Note 35, at velocity 126 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 95); // Play The Note 47, at velocity 95 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(9, 35, 114); // Play The Note 35, at velocity 114 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 95); // Play The Note 40, at velocity 95 on channel 0
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 93); // Play The Note 28, at velocity 93 on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 96); // Play The Note 42, at velocity 96 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 96); // Play The Note 49, at velocity 96 on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(4, 30, 115); // Play The Note 30, at velocity 115 on channel 4
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      player.noteOn(9, 40, 64); // Play The Note 40, at velocity 64 on channel 9
      player.noteOn(9, 50, 64); // Play The Note 50, at velocity 64 on channel 9
      player.noteOn(9, 49, 83); // Play The Note 49, at velocity 83 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      player.noteOn(9, 40, 74); // Play The Note 40, at velocity 74 on channel 9
      player.noteOn(9, 50, 74); // Play The Note 50, at velocity 74 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(9, 40, 84); // Play The Note 40, at velocity 84 on channel 9
      player.noteOn(9, 50, 84); // Play The Note 50, at velocity 84 on channel 9
      player.noteOn(9, 49, 1); // Play The Note 49, at velocity 1 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -512); // Change The Pitch Offset On Channel 4 To -512
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -1024); // Change The Pitch Offset On Channel 4 To -1024
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -1536); // Change The Pitch Offset On Channel 4 To -1536
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 40, 94); // Play The Note 40, at velocity 94 on channel 9
      player.noteOn(9, 50, 94); // Play The Note 50, at velocity 94 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -1920); // Change The Pitch Offset On Channel 4 To -1920
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -2304); // Change The Pitch Offset On Channel 4 To -2304
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -2944); // Change The Pitch Offset On Channel 4 To -2944
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -3584); // Change The Pitch Offset On Channel 4 To -3584
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -4096); // Change The Pitch Offset On Channel 4 To -4096
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 48, 64); // Play The Note 48, at velocity 64 on channel 9
      player.noteOn(9, 50, 64); // Play The Note 50, at velocity 64 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -4992); // Change The Pitch Offset On Channel 4 To -4992
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -5888); // Change The Pitch Offset On Channel 4 To -5888
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -6656); // Change The Pitch Offset On Channel 4 To -6656
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -7296); // Change The Pitch Offset On Channel 4 To -7296
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -7808); // Change The Pitch Offset On Channel 4 To -7808
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 48, 74); // Play The Note 48, at velocity 74 on channel 9
      player.noteOn(9, 50, 74); // Play The Note 50, at velocity 74 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -8192); // Change The Pitch Offset On Channel 4 To -8192
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(9, 48, 84); // Play The Note 48, at velocity 84 on channel 9
      player.noteOn(9, 50, 84); // Play The Note 50, at velocity 84 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 48, 94); // Play The Note 48, at velocity 94 on channel 9
      player.noteOn(9, 50, 94); // Play The Note 50, at velocity 94 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, 0); // Change The Pitch Offset On Channel 4 To 0
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 45, 64); // Play The Note 45, at velocity 64 on channel 9
      player.noteOn(9, 48, 64); // Play The Note 48, at velocity 64 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      player.noteOn(9, 45, 74); // Play The Note 45, at velocity 74 on channel 9
      player.noteOn(9, 48, 74); // Play The Note 48, at velocity 74 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 45, 84); // Play The Note 45, at velocity 84 on channel 9
      player.noteOn(9, 48, 84); // Play The Note 48, at velocity 84 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 45, 94); // Play The Note 45, at velocity 94 on channel 9
      player.noteOn(9, 48, 94); // Play The Note 48, at velocity 94 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 45, 64); // Play The Note 45, at velocity 64 on channel 9
      player.noteOn(9, 43, 64); // Play The Note 43, at velocity 64 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 43); // Turn off Note 43, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      player.noteOn(9, 45, 74); // Play The Note 45, at velocity 74 on channel 9
      player.noteOn(9, 43, 74); // Play The Note 43, at velocity 74 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 43); // Turn off Note 43, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 45, 84); // Play The Note 45, at velocity 84 on channel 9
      player.noteOn(9, 43, 84); // Play The Note 43, at velocity 84 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 43); // Turn off Note 43, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 45, 94); // Play The Note 45, at velocity 94 on channel 9
      player.noteOn(9, 43, 94); // Play The Note 43, at velocity 94 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 43); // Turn off Note 43, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 42, 89); // Play The Note 42, at velocity 89 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 106); // Play The Note 28, at velocity 106 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 93); // Play The Note 42, at velocity 93 on channel 2
      player.noteOn(3, 49, 92); // Play The Note 49, at velocity 92 on channel 3
      player.noteOn(4, 30, 109); // Play The Note 30, at velocity 109 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(9, 42, 89); // Play The Note 42, at velocity 89 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 87); // Play The Note 47, at velocity 87 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 36, 92); // Play The Note 36, at velocity 92 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 40, 84); // Play The Note 40, at velocity 84 on channel 2
      player.noteOn(3, 47, 83); // Play The Note 47, at velocity 83 on channel 3
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 42, 85); // Play The Note 42, at velocity 85 on channel 2
      player.noteOn(3, 49, 84); // Play The Note 49, at velocity 84 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOn(2, 40, 85); // Play The Note 40, at velocity 85 on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOn(3, 47, 84); // Play The Note 47, at velocity 84 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 42, 101); // Play The Note 42, at velocity 101 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(177); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 86); // Play The Note 42, at velocity 86 on channel 2
      player.noteOn(3, 49, 85); // Play The Note 49, at velocity 85 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 120); // Play The Note 42, at velocity 120 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 44, 101); // Play The Note 44, at velocity 101 on channel 2
      player.noteOn(3, 51, 100); // Play The Note 51, at velocity 100 on channel 3
      player.noteOn(4, 32, 110); // Play The Note 32, at velocity 110 on channel 4
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 44, 90); // Play The Note 44, at velocity 90 on channel 2
      player.noteOn(3, 51, 89); // Play The Note 51, at velocity 89 on channel 3
      player.noteOn(4, 32, 98); // Play The Note 32, at velocity 98 on channel 4
      player.noteOn(9, 40, 110); // Play The Note 40, at velocity 110 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 97); // Play The Note 28, at velocity 97 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(2, 42, 88); // Play The Note 42, at velocity 88 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 102); // Play The Note 30, at velocity 102 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOn(3, 47, 87); // Play The Note 47, at velocity 87 on channel 3
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(177); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 107); // Play The Note 28, at velocity 107 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 113); // Play The Note 30, at velocity 113 on channel 4
      player.noteOn(9, 40, 112); // Play The Note 40, at velocity 112 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 109); // Play The Note 30, at velocity 109 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 90); // Play The Note 40, at velocity 90 on channel 2
      player.noteOn(3, 47, 89); // Play The Note 47, at velocity 89 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 87); // Play The Note 47, at velocity 87 on channel 3
      player.noteOn(4, 28, 103); // Play The Note 28, at velocity 103 on channel 4
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 88); // Play The Note 42, at velocity 88 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 110); // Play The Note 30, at velocity 110 on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 110); // Play The Note 30, at velocity 110 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 44, 100); // Play The Note 44, at velocity 100 on channel 2
      player.noteOn(3, 51, 98); // Play The Note 51, at velocity 98 on channel 3
      player.noteOn(4, 32, 108); // Play The Note 32, at velocity 108 on channel 4
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 44, 79); // Play The Note 44, at velocity 79 on channel 2
      player.noteOn(3, 51, 78); // Play The Note 51, at velocity 78 on channel 3
      player.noteOn(4, 32, 105); // Play The Note 32, at velocity 105 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 87); // Play The Note 47, at velocity 87 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 97); // Play The Note 30, at velocity 97 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 88); // Play The Note 42, at velocity 88 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 98); // Play The Note 28, at velocity 98 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 85); // Play The Note 40, at velocity 85 on channel 2
      player.noteOn(3, 47, 84); // Play The Note 47, at velocity 84 on channel 3
      player.noteOn(4, 28, 97); // Play The Note 28, at velocity 97 on channel 4
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 42, 90); // Play The Note 42, at velocity 90 on channel 2
      player.noteOn(3, 49, 89); // Play The Note 49, at velocity 89 on channel 3
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 42, 83); // Play The Note 42, at velocity 83 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(3, 47, 91); // Play The Note 47, at velocity 91 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 86); // Play The Note 42, at velocity 86 on channel 2
      player.noteOn(3, 49, 85); // Play The Note 49, at velocity 85 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 112); // Play The Note 30, at velocity 112 on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 40, 82); // Play The Note 40, at velocity 82 on channel 2
      player.noteOn(3, 47, 81); // Play The Note 47, at velocity 81 on channel 3
      player.noteOn(4, 28, 98); // Play The Note 28, at velocity 98 on channel 4
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 44, 91); // Play The Note 44, at velocity 91 on channel 2
      player.noteOn(3, 51, 90); // Play The Note 51, at velocity 90 on channel 3
      player.noteOn(4, 32, 105); // Play The Note 32, at velocity 105 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 126); // Play The Note 42, at velocity 126 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 44, 88); // Play The Note 44, at velocity 88 on channel 2
      player.noteOn(3, 51, 86); // Play The Note 51, at velocity 86 on channel 3
      player.noteOn(4, 32, 103); // Play The Note 32, at velocity 103 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 103); // Play The Note 28, at velocity 103 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 42, 85); // Play The Note 42, at velocity 85 on channel 2
      player.noteOn(3, 49, 84); // Play The Note 49, at velocity 84 on channel 3
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 42, 124); // Play The Note 42, at velocity 124 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 99); // Play The Note 30, at velocity 99 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 42, 124); // Play The Note 42, at velocity 124 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 109); // Play The Note 30, at velocity 109 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 98); // Play The Note 30, at velocity 98 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 110); // Play The Note 30, at velocity 110 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 112); // Play The Note 30, at velocity 112 on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 98); // Play The Note 30, at velocity 98 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 103); // Play The Note 28, at velocity 103 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 126); // Play The Note 42, at velocity 126 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 44, 99); // Play The Note 44, at velocity 99 on channel 2
      player.noteOn(3, 51, 98); // Play The Note 51, at velocity 98 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 42, 102); // Play The Note 42, at velocity 102 on channel 2
      player.noteOn(3, 49, 100); // Play The Note 49, at velocity 100 on channel 3
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 74); // Play The Note 42, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(260); // Wait For The Next Note
      player.noteOn(9, 46, 101); // Play The Note 46, at velocity 101 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(239); // Wait For The Next Note
      player.noteOn(9, 46, 116); // Play The Note 46, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(270); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 114); // Play The Note 35, at velocity 114 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 47, 90); // Play The Note 47, at velocity 90 on channel 2
      player.noteOn(3, 54, 89); // Play The Note 54, at velocity 89 on channel 3
      player.noteOn(4, 35, 102); // Play The Note 35, at velocity 102 on channel 4
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 105); // Play The Note 33, at velocity 105 on channel 4
      player.noteOn(9, 40, 112); // Play The Note 40, at velocity 112 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(2, 47, 90); // Play The Note 47, at velocity 90 on channel 2
      player.noteOn(3, 54, 88); // Play The Note 54, at velocity 88 on channel 3
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 45, 89); // Play The Note 45, at velocity 89 on channel 2
      player.noteOn(3, 52, 88); // Play The Note 52, at velocity 88 on channel 3
      player.noteOn(4, 33, 101); // Play The Note 33, at velocity 101 on channel 4
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      player.noteOn(9, 57, 77); // Play The Note 57, at velocity 77 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 47, 94); // Play The Note 47, at velocity 94 on channel 2
      player.noteOn(3, 54, 93); // Play The Note 54, at velocity 93 on channel 3
      player.noteOn(4, 35, 107); // Play The Note 35, at velocity 107 on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOn(4, 35, 104); // Play The Note 35, at velocity 104 on channel 4
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 109); // Play The Note 33, at velocity 109 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 45, 90); // Play The Note 45, at velocity 90 on channel 2
      player.noteOn(3, 52, 89); // Play The Note 52, at velocity 89 on channel 3
      player.noteOn(4, 33, 103); // Play The Note 33, at velocity 103 on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 104); // Play The Note 35, at velocity 104 on channel 4
      player.noteOn(9, 36, 124); // Play The Note 36, at velocity 124 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 105); // Play The Note 35, at velocity 105 on channel 4
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 92); // Play The Note 52, at velocity 92 on channel 3
      player.noteOn(4, 33, 112); // Play The Note 33, at velocity 112 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 92); // Play The Note 54, at velocity 92 on channel 3
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 105); // Play The Note 33, at velocity 105 on channel 4
      player.noteOn(9, 36, 127); // Play The Note 36, at velocity 127 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 111); // Play The Note 35, at velocity 111 on channel 4
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 36, 127); // Play The Note 36, at velocity 127 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 45, 91); // Play The Note 45, at velocity 91 on channel 2
      player.noteOn(3, 52, 90); // Play The Note 52, at velocity 90 on channel 3
      player.noteOn(4, 33, 102); // Play The Note 33, at velocity 102 on channel 4
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(229); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 49, 94); // Play The Note 49, at velocity 94 on channel 2
      player.noteOn(3, 56, 93); // Play The Note 56, at velocity 93 on channel 3
      player.noteOn(4, 37, 110); // Play The Note 37, at velocity 110 on channel 4
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOff(2, 49); // Turn off Note 49, on channel 2
      player.noteOff(3, 56); // Turn off Note 56, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 37); // Turn off Note 37, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 45, 91); // Play The Note 45, at velocity 91 on channel 2
      player.noteOn(3, 52, 90); // Play The Note 52, at velocity 90 on channel 3
      player.noteOn(4, 33, 101); // Play The Note 33, at velocity 101 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(229); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      player.noteOn(4, 35, 104); // Play The Note 35, at velocity 104 on channel 4
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 46, 86); // Play The Note 46, at velocity 86 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 47, 91); // Play The Note 47, at velocity 91 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOn(4, 35, 103); // Play The Note 35, at velocity 103 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 45, 92); // Play The Note 45, at velocity 92 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 105); // Play The Note 33, at velocity 105 on channel 4
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 109); // Play The Note 35, at velocity 109 on channel 4
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 45, 92); // Play The Note 45, at velocity 92 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 103); // Play The Note 33, at velocity 103 on channel 4
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 92); // Play The Note 54, at velocity 92 on channel 3
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 47, 91); // Play The Note 47, at velocity 91 on channel 2
      player.noteOn(3, 54, 89); // Play The Note 54, at velocity 89 on channel 3
      player.noteOn(4, 35, 101); // Play The Note 35, at velocity 101 on channel 4
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 110); // Play The Note 33, at velocity 110 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 107); // Play The Note 35, at velocity 107 on channel 4
      player.noteOn(9, 36, 124); // Play The Note 36, at velocity 124 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 45, 92); // Play The Note 45, at velocity 92 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 104); // Play The Note 33, at velocity 104 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 57, 98); // Play The Note 57, at velocity 98 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 47, 91); // Play The Note 47, at velocity 91 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOn(4, 35, 105); // Play The Note 35, at velocity 105 on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOn(4, 35, 109); // Play The Note 35, at velocity 109 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 45, 94); // Play The Note 45, at velocity 94 on channel 2
      player.noteOn(3, 52, 93); // Play The Note 52, at velocity 93 on channel 3
      player.noteOn(4, 33, 110); // Play The Note 33, at velocity 110 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 46, 86); // Play The Note 46, at velocity 86 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 92); // Play The Note 54, at velocity 92 on channel 3
      player.noteOn(4, 35, 113); // Play The Note 35, at velocity 113 on channel 4
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 104); // Play The Note 33, at velocity 104 on channel 4
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 111); // Play The Note 35, at velocity 111 on channel 4
      player.noteOn(9, 36, 124); // Play The Note 36, at velocity 124 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOn(2, 45, 94); // Play The Note 45, at velocity 94 on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOn(3, 52, 93); // Play The Note 52, at velocity 93 on channel 3
      player.noteOn(4, 33, 104); // Play The Note 33, at velocity 104 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(9, 36, 127); // Play The Note 36, at velocity 127 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOn(2, 45, 91); // Play The Note 45, at velocity 91 on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOn(3, 52, 90); // Play The Note 52, at velocity 90 on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      player.noteOn(4, 33, 107); // Play The Note 33, at velocity 107 on channel 4
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 97); // Play The Note 30, at velocity 97 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 88); // Play The Note 42, at velocity 88 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 99); // Play The Note 30, at velocity 99 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 107); // Play The Note 28, at velocity 107 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 85); // Play The Note 40, at velocity 85 on channel 2
      player.noteOn(3, 47, 84); // Play The Note 47, at velocity 84 on channel 3
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 42, 90); // Play The Note 42, at velocity 90 on channel 2
      player.noteOn(3, 49, 89); // Play The Note 49, at velocity 89 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 42, 83); // Play The Note 42, at velocity 83 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 102); // Play The Note 30, at velocity 102 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(3, 47, 91); // Play The Note 47, at velocity 91 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 86); // Play The Note 42, at velocity 86 on channel 2
      player.noteOn(3, 49, 85); // Play The Note 49, at velocity 85 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 40, 82); // Play The Note 40, at velocity 82 on channel 2
      player.noteOn(3, 47, 81); // Play The Note 47, at velocity 81 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 44, 91); // Play The Note 44, at velocity 91 on channel 2
      player.noteOn(3, 51, 90); // Play The Note 51, at velocity 90 on channel 3
      player.noteOn(4, 32, 109); // Play The Note 32, at velocity 109 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 126); // Play The Note 42, at velocity 126 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 44, 88); // Play The Note 44, at velocity 88 on channel 2
      player.noteOn(3, 51, 86); // Play The Note 51, at velocity 86 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 107); // Play The Note 28, at velocity 107 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(2, 42, 85); // Play The Note 42, at velocity 85 on channel 2
      player.noteOn(3, 49, 84); // Play The Note 49, at velocity 84 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 42, 124); // Play The Note 42, at velocity 124 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 42, 124); // Play The Note 42, at velocity 124 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(135); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 106); // Play The Note 28, at velocity 106 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 126); // Play The Note 42, at velocity 126 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 44, 99); // Play The Note 44, at velocity 99 on channel 2
      player.noteOn(3, 51, 98); // Play The Note 51, at velocity 98 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 42, 102); // Play The Note 42, at velocity 102 on channel 2
      player.noteOn(3, 49, 100); // Play The Note 49, at velocity 100 on channel 3
      player.noteOn(4, 30, 115); // Play The Note 30, at velocity 115 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 59, 86); // Play The Note 59, at velocity 86 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(250); // Wait For The Next Note
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(250); // Wait For The Next Note
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(250); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 103); // Play The Note 40, at velocity 103 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 99); // Play The Note 40, at velocity 99 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 110); // Play The Note 38, at velocity 110 on channel 4
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 59, 110); // Play The Note 59, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 101); // Play The Note 40, at velocity 101 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 102); // Play The Note 40, at velocity 102 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 107); // Play The Note 38, at velocity 107 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 100); // Play The Note 38, at velocity 100 on channel 4
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 105); // Play The Note 42, at velocity 105 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 107); // Play The Note 42, at velocity 107 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 104); // Play The Note 38, at velocity 104 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 105); // Play The Note 32, at velocity 105 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 59, 110); // Play The Note 59, at velocity 110 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 106); // Play The Note 32, at velocity 106 on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 59, 110); // Play The Note 59, at velocity 110 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 101); // Play The Note 32, at velocity 101 on channel 4
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 59, 101); // Play The Note 59, at velocity 101 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 59, 101); // Play The Note 59, at velocity 101 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 82); // Play The Note 53, at velocity 82 on channel 3
      player.noteOn(4, 34, 102); // Play The Note 34, at velocity 102 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 59, 86); // Play The Note 59, at velocity 86 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 82); // Play The Note 53, at velocity 82 on channel 3
      player.noteOn(4, 34, 101); // Play The Note 34, at velocity 101 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 59, 86); // Play The Note 59, at velocity 86 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 97); // Play The Note 40, at velocity 97 on channel 4
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 104); // Play The Note 40, at velocity 104 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 104); // Play The Note 38, at velocity 104 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 59, 89); // Play The Note 59, at velocity 89 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 98); // Play The Note 40, at velocity 98 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 97); // Play The Note 40, at velocity 97 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 107); // Play The Note 38, at velocity 107 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 103); // Play The Note 38, at velocity 103 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 103); // Play The Note 42, at velocity 103 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 106); // Play The Note 42, at velocity 106 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 110); // Play The Note 38, at velocity 110 on channel 4
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 59, 110); // Play The Note 59, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 105); // Play The Note 32, at velocity 105 on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      player.noteOn(9, 59, 112); // Play The Note 59, at velocity 112 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 98); // Play The Note 32, at velocity 98 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 113); // Play The Note 30, at velocity 113 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 102); // Play The Note 30, at velocity 102 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 82); // Play The Note 53, at velocity 82 on channel 3
      player.noteOn(4, 34, 115); // Play The Note 34, at velocity 115 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 59, 112); // Play The Note 59, at velocity 112 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 51, 71); // Play The Note 51, at velocity 71 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(229); // Wait For The Next Note
      player.noteOn(9, 51, 77); // Play The Note 51, at velocity 77 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 51, 95); // Play The Note 51, at velocity 95 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 103); // Play The Note 40, at velocity 103 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 51, 98); // Play The Note 51, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 96); // Play The Note 40, at velocity 96 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 105); // Play The Note 38, at velocity 105 on channel 4
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 51, 89); // Play The Note 51, at velocity 89 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 51, 89); // Play The Note 51, at velocity 89 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 103); // Play The Note 40, at velocity 103 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 51, 89); // Play The Note 51, at velocity 89 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 99); // Play The Note 40, at velocity 99 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 107); // Play The Note 38, at velocity 107 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 51, 83); // Play The Note 51, at velocity 83 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 51, 95); // Play The Note 51, at velocity 95 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 98); // Play The Note 38, at velocity 98 on channel 4
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 103); // Play The Note 42, at velocity 103 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      player.noteOn(9, 51, 89); // Play The Note 51, at velocity 89 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 101); // Play The Note 42, at velocity 101 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 110); // Play The Note 38, at velocity 110 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 77); // Play The Note 51, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 104); // Play The Note 32, at velocity 104 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 51, 83); // Play The Note 51, at velocity 83 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 96); // Play The Note 32, at velocity 96 on channel 4
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 51, 95); // Play The Note 51, at velocity 95 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 51, 86); // Play The Note 51, at velocity 86 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 110); // Play The Note 32, at velocity 110 on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOn(9, 51, 83); // Play The Note 51, at velocity 83 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 98); // Play The Note 32, at velocity 98 on channel 4
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 112); // Play The Note 30, at velocity 112 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 51, 101); // Play The Note 51, at velocity 101 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 51, 95); // Play The Note 51, at velocity 95 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 82); // Play The Note 53, at velocity 82 on channel 3
      player.noteOn(4, 34, 106); // Play The Note 34, at velocity 106 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 51, 101); // Play The Note 51, at velocity 101 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 82); // Play The Note 53, at velocity 82 on channel 3
      player.noteOn(4, 34, 106); // Play The Note 34, at velocity 106 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 112); // Play The Note 30, at velocity 112 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 51, 98); // Play The Note 51, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 103); // Play The Note 40, at velocity 103 on channel 4
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 53, 80); // Play The Note 53, at velocity 80 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 100); // Play The Note 40, at velocity 100 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 107); // Play The Note 38, at velocity 107 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 53, 92); // Play The Note 53, at velocity 92 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 53, 74); // Play The Note 53, at velocity 74 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 106); // Play The Note 40, at velocity 106 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 53, 86); // Play The Note 53, at velocity 86 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 102); // Play The Note 40, at velocity 102 on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 105); // Play The Note 38, at velocity 105 on channel 4
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 53, 77); // Play The Note 53, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 53, 80); // Play The Note 53, at velocity 80 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 96); // Play The Note 38, at velocity 96 on channel 4
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 106); // Play The Note 42, at velocity 106 on channel 4
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 53, 74); // Play The Note 53, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 103); // Play The Note 42, at velocity 103 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 105); // Play The Note 38, at velocity 105 on channel 4
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 53, 83); // Play The Note 53, at velocity 83 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      player.noteOn(9, 53, 98); // Play The Note 53, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 110); // Play The Note 32, at velocity 110 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 53, 83); // Play The Note 53, at velocity 83 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(9, 53, 101); // Play The Note 53, at velocity 101 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 111); // Play The Note 32, at velocity 111 on channel 4
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 53, 98); // Play The Note 53, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 82); // Play The Note 53, at velocity 82 on channel 3
      player.noteOn(4, 34, 115); // Play The Note 34, at velocity 115 on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 53, 101); // Play The Note 53, at velocity 101 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      Thread.Sleep(1177); // Wait For The Next Note
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      player.noteOn(9, 57, 83); // Play The Note 57, at velocity 83 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(9, 40, 112); // Play The Note 40, at velocity 112 on channel 9
      player.noteOn(9, 46, 86); // Play The Note 46, at velocity 86 on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 35, 114); // Play The Note 35, at velocity 114 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      player.noteOn(9, 46, 62); // Play The Note 46, at velocity 62 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 110); // Play The Note 35, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 46, 53); // Play The Note 46, at velocity 53 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      player.noteOn(9, 46, 50); // Play The Note 46, at velocity 50 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 46, 53); // Play The Note 46, at velocity 53 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 46, 62); // Play The Note 46, at velocity 62 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(0, 40, 91); // Play The Note 40, at velocity 91 on channel 0
      player.noteOn(1, 47, 91); // Play The Note 47, at velocity 91 on channel 1
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 109); // Play The Note 30, at velocity 109 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 46, 59); // Play The Note 46, at velocity 59 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 43, 94); // Play The Note 43, at velocity 94 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 50, 94); // Play The Note 50, at velocity 94 on channel 1
      player.noteOn(4, 31, 105); // Play The Note 31, at velocity 105 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 53); // Play The Note 46, at velocity 53 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOff(4, 31); // Turn off Note 31, on channel 4
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      player.noteOn(5, 58, 94); // Play The Note 58, at velocity 94 on channel 5
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 43); // Turn off Note 43, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      player.noteOn(9, 46, 53); // Play The Note 46, at velocity 53 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 115); // Play The Note 30, at velocity 115 on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 35, 124); // Play The Note 35, at velocity 124 on channel 9
      player.noteOn(9, 57, 80); // Play The Note 57, at velocity 80 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 95); // Play The Note 46, at velocity 95 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 46, 59); // Play The Note 46, at velocity 59 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 91); // Play The Note 47, at velocity 91 on channel 1
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 91); // Play The Note 40, at velocity 91 on channel 0
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 93); // Play The Note 42, at velocity 93 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 93); // Play The Note 49, at velocity 93 on channel 1
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 35, 124); // Play The Note 35, at velocity 124 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 35, 114); // Play The Note 35, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 94); // Play The Note 40, at velocity 94 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 94); // Play The Note 47, at velocity 94 on channel 1
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 94); // Play The Note 28, at velocity 94 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 110); // Play The Note 30, at velocity 110 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 35, 126); // Play The Note 35, at velocity 126 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 93); // Play The Note 40, at velocity 93 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 93); // Play The Note 47, at velocity 93 on channel 1
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(1, 47, 90); // Play The Note 47, at velocity 90 on channel 1
      player.noteOn(4, 28, 97); // Play The Note 28, at velocity 97 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 90); // Play The Note 40, at velocity 90 on channel 0
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 94); // Play The Note 42, at velocity 94 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 94); // Play The Note 49, at velocity 94 on channel 1
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 43, 92); // Play The Note 43, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 50, 92); // Play The Note 50, at velocity 92 on channel 1
      player.noteOn(4, 31, 100); // Play The Note 31, at velocity 100 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 59, 95); // Play The Note 59, at velocity 95 on channel 5
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(4, 31); // Turn off Note 31, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 49, 94); // Play The Note 49, at velocity 94 on channel 1
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 43); // Turn off Note 43, on channel 0
      player.noteOn(0, 42, 94); // Play The Note 42, at velocity 94 on channel 0
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 35, 104); // Play The Note 35, at velocity 104 on channel 9
      player.noteOn(9, 33, 56); // Play The Note 33, at velocity 56 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 33); // Turn off Note 33, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 93); // Play The Note 40, at velocity 93 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 93); // Play The Note 47, at velocity 93 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 93); // Play The Note 49, at velocity 93 on channel 1
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOn(5, 58, 98); // Play The Note 58, at velocity 98 on channel 5
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 57, 86); // Play The Note 57, at velocity 86 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 93); // Play The Note 42, at velocity 93 on channel 0
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 107); // Play The Note 28, at velocity 107 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 114); // Play The Note 35, at velocity 114 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 93); // Play The Note 40, at velocity 93 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 93); // Play The Note 47, at velocity 93 on channel 1
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(1, 47, 91); // Play The Note 47, at velocity 91 on channel 1
      player.noteOn(4, 28, 97); // Play The Note 28, at velocity 97 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 91); // Play The Note 40, at velocity 91 on channel 0
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 43, 92); // Play The Note 43, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 50, 92); // Play The Note 50, at velocity 92 on channel 1
      player.noteOn(4, 31, 105); // Play The Note 31, at velocity 105 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 59, 94); // Play The Note 59, at velocity 94 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(177); // Wait For The Next Note
      player.noteOff(4, 31); // Turn off Note 31, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 43); // Turn off Note 43, on channel 0
      player.noteOn(0, 42, 93); // Play The Note 42, at velocity 93 on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 49, 93); // Play The Note 49, at velocity 93 on channel 1
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 35, 126); // Play The Note 35, at velocity 126 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 95); // Play The Note 46, at velocity 95 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 95); // Play The Note 49, at velocity 95 on channel 1
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 57, 89); // Play The Note 57, at velocity 89 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 95); // Play The Note 42, at velocity 95 on channel 0
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 103); // Play The Note 28, at velocity 103 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 35, 120); // Play The Note 35, at velocity 120 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(1, 47, 91); // Play The Note 47, at velocity 91 on channel 1
      player.noteOn(4, 28, 98); // Play The Note 28, at velocity 98 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(0, 40, 91); // Play The Note 40, at velocity 91 on channel 0
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 92); // Play The Note 42, at velocity 92 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 92); // Play The Note 49, at velocity 92 on channel 1
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 35, 126); // Play The Note 35, at velocity 126 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 35, 122); // Play The Note 35, at velocity 122 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOn(0, 40, 95); // Play The Note 40, at velocity 95 on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 47, 95); // Play The Note 47, at velocity 95 on channel 1
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 35, 114); // Play The Note 35, at velocity 114 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(0, 40, 92); // Play The Note 40, at velocity 92 on channel 0
      player.noteOn(1, 47, 92); // Play The Note 47, at velocity 92 on channel 1
      player.noteOn(4, 28, 93); // Play The Note 28, at velocity 93 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 49, 96); // Play The Note 49, at velocity 96 on channel 1
      player.noteOn(4, 30, 115); // Play The Note 30, at velocity 115 on channel 4
      player.noteOn(5, 58, 98); // Play The Note 58, at velocity 98 on channel 5
      player.noteOn(9, 35, 116); // Play The Note 35, at velocity 116 on channel 9
      player.noteOn(9, 40, 64); // Play The Note 40, at velocity 64 on channel 9
      player.noteOn(9, 50, 64); // Play The Note 50, at velocity 64 on channel 9
      player.noteOn(9, 49, 83); // Play The Note 49, at velocity 83 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 42, 96); // Play The Note 42, at velocity 96 on channel 0
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      player.noteOn(9, 40, 74); // Play The Note 40, at velocity 74 on channel 9
      player.noteOn(9, 50, 74); // Play The Note 50, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 42); // Turn off Note 42, on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(9, 40, 84); // Play The Note 40, at velocity 84 on channel 9
      player.noteOn(9, 50, 84); // Play The Note 50, at velocity 84 on channel 9
      player.noteOn(9, 49, 1); // Play The Note 49, at velocity 1 on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.pitchBend(4, -512); // Change The Pitch Offset On Channel 4 To -512
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -1024); // Change The Pitch Offset On Channel 4 To -1024
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -1536); // Change The Pitch Offset On Channel 4 To -1536
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -1920); // Change The Pitch Offset On Channel 4 To -1920
      player.noteOn(9, 40, 94); // Play The Note 40, at velocity 94 on channel 9
      player.noteOn(9, 50, 94); // Play The Note 50, at velocity 94 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -2304); // Change The Pitch Offset On Channel 4 To -2304
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -2944); // Change The Pitch Offset On Channel 4 To -2944
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -3584); // Change The Pitch Offset On Channel 4 To -3584
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -4096); // Change The Pitch Offset On Channel 4 To -4096
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -4992); // Change The Pitch Offset On Channel 4 To -4992
      player.noteOn(9, 35, 125); // Play The Note 35, at velocity 125 on channel 9
      player.noteOn(9, 48, 64); // Play The Note 48, at velocity 64 on channel 9
      player.noteOn(9, 50, 64); // Play The Note 50, at velocity 64 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -5888); // Change The Pitch Offset On Channel 4 To -5888
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -6656); // Change The Pitch Offset On Channel 4 To -6656
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -7296); // Change The Pitch Offset On Channel 4 To -7296
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -7808); // Change The Pitch Offset On Channel 4 To -7808
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      player.noteOn(9, 48, 74); // Play The Note 48, at velocity 74 on channel 9
      player.noteOn(9, 50, 74); // Play The Note 50, at velocity 74 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -8192); // Change The Pitch Offset On Channel 4 To -8192
      Thread.Sleep(41); // Wait For The Next Note
      player.pitchBend(4, -7808); // Change The Pitch Offset On Channel 4 To -7808
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -6528); // Change The Pitch Offset On Channel 4 To -6528
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOn(9, 48, 84); // Play The Note 48, at velocity 84 on channel 9
      player.noteOn(9, 50, 84); // Play The Note 50, at velocity 84 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -4864); // Change The Pitch Offset On Channel 4 To -4864
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -3584); // Change The Pitch Offset On Channel 4 To -3584
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -2560); // Change The Pitch Offset On Channel 4 To -2560
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -1792); // Change The Pitch Offset On Channel 4 To -1792
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -1280); // Change The Pitch Offset On Channel 4 To -1280
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 48, 94); // Play The Note 48, at velocity 94 on channel 9
      player.noteOn(9, 50, 94); // Play The Note 50, at velocity 94 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -768); // Change The Pitch Offset On Channel 4 To -768
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, -512); // Change The Pitch Offset On Channel 4 To -512
      Thread.Sleep(10); // Wait For The Next Note
      player.pitchBend(4, -256); // Change The Pitch Offset On Channel 4 To -256
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(4, 0); // Change The Pitch Offset On Channel 4 To 0
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 45, 64); // Play The Note 45, at velocity 64 on channel 9
      player.noteOn(9, 48, 64); // Play The Note 48, at velocity 64 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      player.noteOn(9, 45, 74); // Play The Note 45, at velocity 74 on channel 9
      player.noteOn(9, 48, 74); // Play The Note 48, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 45, 84); // Play The Note 45, at velocity 84 on channel 9
      player.noteOn(9, 48, 84); // Play The Note 48, at velocity 84 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 45, 94); // Play The Note 45, at velocity 94 on channel 9
      player.noteOn(9, 48, 94); // Play The Note 48, at velocity 94 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 48); // Turn off Note 48, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 35, 127); // Play The Note 35, at velocity 127 on channel 9
      player.noteOn(9, 45, 64); // Play The Note 45, at velocity 64 on channel 9
      player.noteOn(9, 43, 64); // Play The Note 43, at velocity 64 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 43); // Turn off Note 43, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 35); // Turn off Note 35, on channel 9
      player.noteOn(9, 45, 74); // Play The Note 45, at velocity 74 on channel 9
      player.noteOn(9, 43, 74); // Play The Note 43, at velocity 74 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 43); // Turn off Note 43, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 45, 84); // Play The Note 45, at velocity 84 on channel 9
      player.noteOn(9, 43, 84); // Play The Note 43, at velocity 84 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 43); // Turn off Note 43, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 45, 94); // Play The Note 45, at velocity 94 on channel 9
      player.noteOn(9, 43, 94); // Play The Note 43, at velocity 94 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 43); // Turn off Note 43, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 106); // Play The Note 28, at velocity 106 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 42, 89); // Play The Note 42, at velocity 89 on channel 9
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 93); // Play The Note 42, at velocity 93 on channel 2
      player.noteOn(3, 49, 92); // Play The Note 49, at velocity 92 on channel 3
      player.noteOn(4, 30, 109); // Play The Note 30, at velocity 109 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 42, 89); // Play The Note 42, at velocity 89 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 87); // Play The Note 47, at velocity 87 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 92); // Play The Note 36, at velocity 92 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 84); // Play The Note 40, at velocity 84 on channel 2
      player.noteOn(3, 47, 83); // Play The Note 47, at velocity 83 on channel 3
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 98); // Play The Note 58, at velocity 98 on channel 5
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 42, 85); // Play The Note 42, at velocity 85 on channel 2
      player.noteOn(3, 49, 84); // Play The Note 49, at velocity 84 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 85); // Play The Note 40, at velocity 85 on channel 2
      player.noteOn(3, 47, 84); // Play The Note 47, at velocity 84 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 42, 101); // Play The Note 42, at velocity 101 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(177); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 42, 86); // Play The Note 42, at velocity 86 on channel 2
      player.noteOn(3, 49, 85); // Play The Note 49, at velocity 85 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 120); // Play The Note 42, at velocity 120 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 99); // Play The Note 28, at velocity 99 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 44, 101); // Play The Note 44, at velocity 101 on channel 2
      player.noteOn(3, 51, 77); // Play The Note 51, at velocity 77 on channel 3
      player.noteOn(4, 32, 110); // Play The Note 32, at velocity 110 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 44, 90); // Play The Note 44, at velocity 90 on channel 2
      player.noteOn(3, 51, 76); // Play The Note 51, at velocity 76 on channel 3
      player.noteOn(4, 32, 98); // Play The Note 32, at velocity 98 on channel 4
      player.noteOn(5, 59, 95); // Play The Note 59, at velocity 95 on channel 5
      player.noteOn(9, 40, 110); // Play The Note 40, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 97); // Play The Note 28, at velocity 97 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(135); // Wait For The Next Note
      player.noteOn(2, 42, 88); // Play The Note 42, at velocity 88 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 102); // Play The Note 30, at velocity 102 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 87); // Play The Note 47, at velocity 87 on channel 3
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 107); // Play The Note 28, at velocity 107 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 113); // Play The Note 30, at velocity 113 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      player.noteOn(9, 40, 112); // Play The Note 40, at velocity 112 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 109); // Play The Note 30, at velocity 109 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 90); // Play The Note 40, at velocity 90 on channel 2
      player.noteOn(3, 47, 89); // Play The Note 47, at velocity 89 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 94); // Play The Note 58, at velocity 94 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 87); // Play The Note 47, at velocity 87 on channel 3
      player.noteOn(4, 28, 103); // Play The Note 28, at velocity 103 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 88); // Play The Note 42, at velocity 88 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 110); // Play The Note 30, at velocity 110 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 110); // Play The Note 30, at velocity 110 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 44, 100); // Play The Note 44, at velocity 100 on channel 2
      player.noteOn(3, 51, 76); // Play The Note 51, at velocity 76 on channel 3
      player.noteOn(4, 32, 108); // Play The Note 32, at velocity 108 on channel 4
      player.noteOn(5, 59, 93); // Play The Note 59, at velocity 93 on channel 5
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 44, 79); // Play The Note 44, at velocity 79 on channel 2
      player.noteOn(3, 51, 71); // Play The Note 51, at velocity 71 on channel 3
      player.noteOn(4, 32, 105); // Play The Note 32, at velocity 105 on channel 4
      player.noteOn(5, 59, 95); // Play The Note 59, at velocity 95 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 87); // Play The Note 47, at velocity 87 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(135); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 97); // Play The Note 30, at velocity 97 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 88); // Play The Note 42, at velocity 88 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 98); // Play The Note 28, at velocity 98 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 85); // Play The Note 40, at velocity 85 on channel 2
      player.noteOn(3, 47, 84); // Play The Note 47, at velocity 84 on channel 3
      player.noteOn(4, 28, 97); // Play The Note 28, at velocity 97 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 42, 90); // Play The Note 42, at velocity 90 on channel 2
      player.noteOn(3, 49, 89); // Play The Note 49, at velocity 89 on channel 3
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 42, 83); // Play The Note 42, at velocity 83 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(3, 47, 91); // Play The Note 47, at velocity 91 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 86); // Play The Note 42, at velocity 86 on channel 2
      player.noteOn(3, 49, 85); // Play The Note 49, at velocity 85 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 112); // Play The Note 30, at velocity 112 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 40, 82); // Play The Note 40, at velocity 82 on channel 2
      player.noteOn(3, 47, 81); // Play The Note 47, at velocity 81 on channel 3
      player.noteOn(4, 28, 98); // Play The Note 28, at velocity 98 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 44, 91); // Play The Note 44, at velocity 91 on channel 2
      player.noteOn(3, 51, 77); // Play The Note 51, at velocity 77 on channel 3
      player.noteOn(4, 32, 105); // Play The Note 32, at velocity 105 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 126); // Play The Note 42, at velocity 126 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 44, 88); // Play The Note 44, at velocity 88 on channel 2
      player.noteOn(3, 51, 77); // Play The Note 51, at velocity 77 on channel 3
      player.noteOn(4, 32, 103); // Play The Note 32, at velocity 103 on channel 4
      player.noteOn(5, 59, 93); // Play The Note 59, at velocity 93 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 103); // Play The Note 28, at velocity 103 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 42, 85); // Play The Note 42, at velocity 85 on channel 2
      player.noteOn(3, 49, 84); // Play The Note 49, at velocity 84 on channel 3
      player.noteOn(4, 30, 106); // Play The Note 30, at velocity 106 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 42, 124); // Play The Note 42, at velocity 124 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 99); // Play The Note 30, at velocity 99 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 42, 124); // Play The Note 42, at velocity 124 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 109); // Play The Note 30, at velocity 109 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 98); // Play The Note 30, at velocity 98 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 110); // Play The Note 30, at velocity 110 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 112); // Play The Note 30, at velocity 112 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 98); // Play The Note 30, at velocity 98 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 103); // Play The Note 28, at velocity 103 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 126); // Play The Note 42, at velocity 126 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 44, 99); // Play The Note 44, at velocity 99 on channel 2
      player.noteOn(3, 51, 75); // Play The Note 51, at velocity 75 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 42, 102); // Play The Note 42, at velocity 102 on channel 2
      player.noteOn(3, 49, 100); // Play The Note 49, at velocity 100 on channel 3
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOn(5, 58, 98); // Play The Note 58, at velocity 98 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 74); // Play The Note 42, at velocity 74 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(260); // Wait For The Next Note
      player.noteOn(9, 46, 101); // Play The Note 46, at velocity 101 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(239); // Wait For The Next Note
      player.noteOn(9, 46, 116); // Play The Note 46, at velocity 116 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(270); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 114); // Play The Note 35, at velocity 114 on channel 4
      player.noteOn(5, 63, 98); // Play The Note 63, at velocity 98 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 47, 90); // Play The Note 47, at velocity 90 on channel 2
      player.noteOn(3, 54, 89); // Play The Note 54, at velocity 89 on channel 3
      player.noteOn(4, 35, 102); // Play The Note 35, at velocity 102 on channel 4
      player.noteOn(5, 63, 96); // Play The Note 63, at velocity 96 on channel 5
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 105); // Play The Note 33, at velocity 105 on channel 4
      player.noteOn(5, 61, 98); // Play The Note 61, at velocity 98 on channel 5
      player.noteOn(9, 40, 112); // Play The Note 40, at velocity 112 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(2, 47, 90); // Play The Note 47, at velocity 90 on channel 2
      player.noteOn(3, 54, 88); // Play The Note 54, at velocity 88 on channel 3
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOn(5, 63, 98); // Play The Note 63, at velocity 98 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      player.noteOn(9, 46, 83); // Play The Note 46, at velocity 83 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(2, 45, 89); // Play The Note 45, at velocity 89 on channel 2
      player.noteOn(3, 52, 88); // Play The Note 52, at velocity 88 on channel 3
      player.noteOn(4, 33, 101); // Play The Note 33, at velocity 101 on channel 4
      player.noteOn(5, 61, 95); // Play The Note 61, at velocity 95 on channel 5
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      player.noteOn(9, 57, 77); // Play The Note 57, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 47, 94); // Play The Note 47, at velocity 94 on channel 2
      player.noteOn(3, 54, 93); // Play The Note 54, at velocity 93 on channel 3
      player.noteOn(4, 35, 107); // Play The Note 35, at velocity 107 on channel 4
      player.noteOn(5, 63, 97); // Play The Note 63, at velocity 97 on channel 5
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOn(4, 35, 104); // Play The Note 35, at velocity 104 on channel 4
      player.noteOn(5, 63, 96); // Play The Note 63, at velocity 96 on channel 5
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 109); // Play The Note 33, at velocity 109 on channel 4
      player.noteOn(5, 61, 98); // Play The Note 61, at velocity 98 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOn(5, 63, 98); // Play The Note 63, at velocity 98 on channel 5
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 45, 90); // Play The Note 45, at velocity 90 on channel 2
      player.noteOn(3, 52, 89); // Play The Note 52, at velocity 89 on channel 3
      player.noteOn(4, 33, 103); // Play The Note 33, at velocity 103 on channel 4
      player.noteOn(5, 61, 95); // Play The Note 61, at velocity 95 on channel 5
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 104); // Play The Note 35, at velocity 104 on channel 4
      player.noteOn(5, 63, 97); // Play The Note 63, at velocity 97 on channel 5
      player.noteOn(9, 36, 124); // Play The Note 36, at velocity 124 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 105); // Play The Note 35, at velocity 105 on channel 4
      player.noteOn(5, 63, 96); // Play The Note 63, at velocity 96 on channel 5
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 92); // Play The Note 52, at velocity 92 on channel 3
      player.noteOn(4, 33, 112); // Play The Note 33, at velocity 112 on channel 4
      player.noteOn(5, 61, 97); // Play The Note 61, at velocity 97 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 92); // Play The Note 54, at velocity 92 on channel 3
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOn(5, 63, 97); // Play The Note 63, at velocity 97 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 105); // Play The Note 33, at velocity 105 on channel 4
      player.noteOn(5, 61, 97); // Play The Note 61, at velocity 97 on channel 5
      player.noteOn(9, 36, 127); // Play The Note 36, at velocity 127 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 111); // Play The Note 35, at velocity 111 on channel 4
      player.noteOn(5, 63, 98); // Play The Note 63, at velocity 98 on channel 5
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(9, 36, 127); // Play The Note 36, at velocity 127 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 45, 91); // Play The Note 45, at velocity 91 on channel 2
      player.noteOn(3, 52, 90); // Play The Note 52, at velocity 90 on channel 3
      player.noteOn(4, 33, 102); // Play The Note 33, at velocity 102 on channel 4
      player.noteOn(5, 61, 96); // Play The Note 61, at velocity 96 on channel 5
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 49, 94); // Play The Note 49, at velocity 94 on channel 2
      player.noteOn(3, 56, 77); // Play The Note 56, at velocity 77 on channel 3
      player.noteOn(4, 37, 110); // Play The Note 37, at velocity 110 on channel 4
      player.noteOn(5, 64, 96); // Play The Note 64, at velocity 96 on channel 5
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(187); // Wait For The Next Note
      player.noteOff(2, 49); // Turn off Note 49, on channel 2
      player.noteOff(3, 56); // Turn off Note 56, on channel 3
      player.noteOff(4, 37); // Turn off Note 37, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 45, 91); // Play The Note 45, at velocity 91 on channel 2
      player.noteOn(3, 52, 90); // Play The Note 52, at velocity 90 on channel 3
      player.noteOn(4, 33, 101); // Play The Note 33, at velocity 101 on channel 4
      player.noteOn(5, 61, 97); // Play The Note 61, at velocity 97 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 64); // Turn off Note 64, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(229); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOn(4, 35, 104); // Play The Note 35, at velocity 104 on channel 4
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      player.noteOn(5, 63, 97); // Play The Note 63, at velocity 97 on channel 5
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 46, 86); // Play The Note 46, at velocity 86 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 47, 91); // Play The Note 47, at velocity 91 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOn(4, 35, 103); // Play The Note 35, at velocity 103 on channel 4
      player.noteOn(5, 63, 96); // Play The Note 63, at velocity 96 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 45, 92); // Play The Note 45, at velocity 92 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 105); // Play The Note 33, at velocity 105 on channel 4
      player.noteOn(5, 61, 98); // Play The Note 61, at velocity 98 on channel 5
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 109); // Play The Note 35, at velocity 109 on channel 4
      player.noteOn(5, 63, 97); // Play The Note 63, at velocity 97 on channel 5
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 45, 92); // Play The Note 45, at velocity 92 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 103); // Play The Note 33, at velocity 103 on channel 4
      player.noteOn(5, 61, 95); // Play The Note 61, at velocity 95 on channel 5
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 92); // Play The Note 54, at velocity 92 on channel 3
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOn(5, 63, 96); // Play The Note 63, at velocity 96 on channel 5
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 47, 91); // Play The Note 47, at velocity 91 on channel 2
      player.noteOn(3, 54, 89); // Play The Note 54, at velocity 89 on channel 3
      player.noteOn(4, 35, 101); // Play The Note 35, at velocity 101 on channel 4
      player.noteOn(5, 63, 96); // Play The Note 63, at velocity 96 on channel 5
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 110); // Play The Note 33, at velocity 110 on channel 4
      player.noteOn(5, 61, 97); // Play The Note 61, at velocity 97 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 107); // Play The Note 35, at velocity 107 on channel 4
      player.noteOn(5, 63, 96); // Play The Note 63, at velocity 96 on channel 5
      player.noteOn(9, 36, 124); // Play The Note 36, at velocity 124 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 40, 116); // Play The Note 40, at velocity 116 on channel 9
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(2, 45, 92); // Play The Note 45, at velocity 92 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 104); // Play The Note 33, at velocity 104 on channel 4
      player.noteOn(5, 61, 96); // Play The Note 61, at velocity 96 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 57, 98); // Play The Note 57, at velocity 98 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 47, 91); // Play The Note 47, at velocity 91 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOn(4, 35, 105); // Play The Note 35, at velocity 105 on channel 4
      player.noteOn(5, 63, 98); // Play The Note 63, at velocity 98 on channel 5
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 47, 92); // Play The Note 47, at velocity 92 on channel 2
      player.noteOn(3, 54, 90); // Play The Note 54, at velocity 90 on channel 3
      player.noteOn(4, 35, 109); // Play The Note 35, at velocity 109 on channel 4
      player.noteOn(5, 63, 97); // Play The Note 63, at velocity 97 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 45, 94); // Play The Note 45, at velocity 94 on channel 2
      player.noteOn(3, 52, 93); // Play The Note 52, at velocity 93 on channel 3
      player.noteOn(4, 33, 110); // Play The Note 33, at velocity 110 on channel 4
      player.noteOn(5, 61, 98); // Play The Note 61, at velocity 98 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 46, 89); // Play The Note 46, at velocity 89 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(197); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 46, 86); // Play The Note 46, at velocity 86 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 92); // Play The Note 54, at velocity 92 on channel 3
      player.noteOn(4, 35, 113); // Play The Note 35, at velocity 113 on channel 4
      player.noteOn(5, 63, 98); // Play The Note 63, at velocity 98 on channel 5
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 40, 125); // Play The Note 40, at velocity 125 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 45, 93); // Play The Note 45, at velocity 93 on channel 2
      player.noteOn(3, 52, 91); // Play The Note 52, at velocity 91 on channel 3
      player.noteOn(4, 33, 104); // Play The Note 33, at velocity 104 on channel 4
      player.noteOn(5, 61, 94); // Play The Note 61, at velocity 94 on channel 5
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOn(4, 35, 111); // Play The Note 35, at velocity 111 on channel 4
      player.noteOn(5, 63, 98); // Play The Note 63, at velocity 98 on channel 5
      player.noteOn(9, 36, 124); // Play The Note 36, at velocity 124 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(9, 36, 125); // Play The Note 36, at velocity 125 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOn(2, 45, 94); // Play The Note 45, at velocity 94 on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOn(3, 52, 93); // Play The Note 52, at velocity 93 on channel 3
      player.noteOn(4, 33, 104); // Play The Note 33, at velocity 104 on channel 4
      player.noteOn(5, 61, 95); // Play The Note 61, at velocity 95 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 46, 77); // Play The Note 46, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(9, 36, 127); // Play The Note 36, at velocity 127 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOn(2, 47, 93); // Play The Note 47, at velocity 93 on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOn(3, 54, 91); // Play The Note 54, at velocity 91 on channel 3
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      player.noteOn(4, 35, 110); // Play The Note 35, at velocity 110 on channel 4
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      player.noteOn(5, 63, 97); // Play The Note 63, at velocity 97 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 47); // Turn off Note 47, on channel 2
      player.noteOn(2, 45, 91); // Play The Note 45, at velocity 91 on channel 2
      player.noteOff(3, 54); // Turn off Note 54, on channel 3
      player.noteOn(3, 52, 90); // Play The Note 52, at velocity 90 on channel 3
      player.noteOff(4, 35); // Turn off Note 35, on channel 4
      player.noteOn(4, 33, 107); // Play The Note 33, at velocity 107 on channel 4
      player.noteOn(5, 61, 95); // Play The Note 61, at velocity 95 on channel 5
      player.noteOn(9, 40, 126); // Play The Note 40, at velocity 126 on channel 9
      player.noteOn(9, 46, 74); // Play The Note 46, at velocity 74 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(5, 63); // Turn off Note 63, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(4, 33); // Turn off Note 33, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 45); // Turn off Note 45, on channel 2
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOff(3, 52); // Turn off Note 52, on channel 3
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 97); // Play The Note 30, at velocity 97 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(5, 58, 94); // Play The Note 58, at velocity 94 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 88); // Play The Note 42, at velocity 88 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 99); // Play The Note 30, at velocity 99 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 107); // Play The Note 28, at velocity 107 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 114); // Play The Note 42, at velocity 114 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 40, 85); // Play The Note 40, at velocity 85 on channel 2
      player.noteOn(3, 47, 84); // Play The Note 47, at velocity 84 on channel 3
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 42, 90); // Play The Note 42, at velocity 90 on channel 2
      player.noteOn(3, 49, 89); // Play The Note 49, at velocity 89 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 42, 83); // Play The Note 42, at velocity 83 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 102); // Play The Note 30, at velocity 102 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(3, 47, 91); // Play The Note 47, at velocity 91 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 42, 107); // Play The Note 42, at velocity 107 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 86); // Play The Note 42, at velocity 86 on channel 2
      player.noteOn(3, 49, 85); // Play The Note 49, at velocity 85 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(3, 47, 85); // Play The Note 47, at velocity 85 on channel 3
      player.noteOn(4, 28, 100); // Play The Note 28, at velocity 100 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 122); // Play The Note 42, at velocity 122 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 96); // Play The Note 42, at velocity 96 on channel 2
      player.noteOn(3, 49, 95); // Play The Note 49, at velocity 95 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 87); // Play The Note 40, at velocity 87 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 42, 125); // Play The Note 42, at velocity 125 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 82); // Play The Note 40, at velocity 82 on channel 2
      player.noteOn(3, 47, 81); // Play The Note 47, at velocity 81 on channel 3
      player.noteOn(4, 28, 101); // Play The Note 28, at velocity 101 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 44, 91); // Play The Note 44, at velocity 91 on channel 2
      player.noteOn(3, 51, 77); // Play The Note 51, at velocity 77 on channel 3
      player.noteOn(4, 32, 109); // Play The Note 32, at velocity 109 on channel 4
      player.noteOn(5, 59, 93); // Play The Note 59, at velocity 93 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 126); // Play The Note 42, at velocity 126 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 44, 88); // Play The Note 44, at velocity 88 on channel 2
      player.noteOn(3, 51, 77); // Play The Note 51, at velocity 77 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(5, 59, 92); // Play The Note 59, at velocity 92 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 107); // Play The Note 28, at velocity 107 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 42, 85); // Play The Note 42, at velocity 85 on channel 2
      player.noteOn(3, 49, 84); // Play The Note 49, at velocity 84 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 42, 124); // Play The Note 42, at velocity 124 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 98); // Play The Note 58, at velocity 98 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 42, 124); // Play The Note 42, at velocity 124 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(135); // Wait For The Next Note
      player.noteOn(9, 42, 118); // Play The Note 42, at velocity 118 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 42, 104); // Play The Note 42, at velocity 104 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 101); // Play The Note 30, at velocity 101 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 106); // Play The Note 28, at velocity 106 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 42, 89); // Play The Note 42, at velocity 89 on channel 2
      player.noteOn(3, 49, 88); // Play The Note 49, at velocity 88 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 42, 91); // Play The Note 42, at velocity 91 on channel 2
      player.noteOn(3, 49, 90); // Play The Note 49, at velocity 90 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 40, 88); // Play The Note 40, at velocity 88 on channel 2
      player.noteOn(3, 47, 86); // Play The Note 47, at velocity 86 on channel 3
      player.noteOn(4, 28, 102); // Play The Note 28, at velocity 102 on channel 4
      player.noteOn(5, 56, 98); // Play The Note 56, at velocity 98 on channel 5
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 42, 110); // Play The Note 42, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(2, 42, 94); // Play The Note 42, at velocity 94 on channel 2
      player.noteOn(3, 49, 93); // Play The Note 49, at velocity 93 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 42, 87); // Play The Note 42, at velocity 87 on channel 2
      player.noteOn(3, 49, 86); // Play The Note 49, at velocity 86 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(3, 47, 88); // Play The Note 47, at velocity 88 on channel 3
      player.noteOn(4, 28, 104); // Play The Note 28, at velocity 104 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 42, 126); // Play The Note 42, at velocity 126 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 42, 127); // Play The Note 42, at velocity 127 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 44, 99); // Play The Note 44, at velocity 99 on channel 2
      player.noteOn(3, 51, 75); // Play The Note 51, at velocity 75 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 44); // Turn off Note 44, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOn(9, 42, 116); // Play The Note 42, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 42); // Turn off Note 42, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 40, 91); // Play The Note 40, at velocity 91 on channel 2
      player.noteOn(3, 47, 90); // Play The Note 47, at velocity 90 on channel 3
      player.noteOn(4, 28, 105); // Play The Note 28, at velocity 105 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 28); // Turn off Note 28, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 42, 102); // Play The Note 42, at velocity 102 on channel 2
      player.noteOn(3, 49, 100); // Play The Note 49, at velocity 100 on channel 3
      player.noteOn(4, 30, 115); // Play The Note 30, at velocity 115 on channel 4
      player.noteOn(5, 58, 98); // Play The Note 58, at velocity 98 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 42); // Turn off Note 42, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 59, 86); // Play The Note 59, at velocity 86 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(260); // Wait For The Next Note
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(239); // Wait For The Next Note
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(250); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 103); // Play The Note 40, at velocity 103 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 99); // Play The Note 40, at velocity 99 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 110); // Play The Note 38, at velocity 110 on channel 4
      player.noteOn(5, 54, 96); // Play The Note 54, at velocity 96 on channel 5
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 59, 110); // Play The Note 59, at velocity 110 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 101); // Play The Note 40, at velocity 101 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 102); // Play The Note 40, at velocity 102 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 107); // Play The Note 38, at velocity 107 on channel 4
      player.noteOn(5, 54, 96); // Play The Note 54, at velocity 96 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 100); // Play The Note 38, at velocity 100 on channel 4
      player.noteOn(5, 54, 96); // Play The Note 54, at velocity 96 on channel 5
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 105); // Play The Note 42, at velocity 105 on channel 4
      player.noteOn(5, 57, 95); // Play The Note 57, at velocity 95 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 57); // Turn off Note 57, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 107); // Play The Note 42, at velocity 107 on channel 4
      player.noteOn(5, 57, 96); // Play The Note 57, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      player.noteOff(5, 57); // Turn off Note 57, on channel 5
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 104); // Play The Note 38, at velocity 104 on channel 4
      player.noteOn(5, 54, 97); // Play The Note 54, at velocity 97 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 105); // Play The Note 32, at velocity 105 on channel 4
      player.noteOn(5, 59, 95); // Play The Note 59, at velocity 95 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(5, 59, 95); // Play The Note 59, at velocity 95 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 59, 110); // Play The Note 59, at velocity 110 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 106); // Play The Note 32, at velocity 106 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 59, 110); // Play The Note 59, at velocity 110 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 101); // Play The Note 32, at velocity 101 on channel 4
      player.noteOn(5, 59, 94); // Play The Note 59, at velocity 94 on channel 5
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 59, 101); // Play The Note 59, at velocity 101 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 59, 101); // Play The Note 59, at velocity 101 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 105); // Play The Note 30, at velocity 105 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 76); // Play The Note 53, at velocity 76 on channel 3
      player.noteOn(4, 34, 102); // Play The Note 34, at velocity 102 on channel 4
      player.noteOn(5, 61, 96); // Play The Note 61, at velocity 96 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 59, 86); // Play The Note 59, at velocity 86 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 76); // Play The Note 53, at velocity 76 on channel 3
      player.noteOn(4, 34, 101); // Play The Note 34, at velocity 101 on channel 4
      player.noteOn(5, 61, 94); // Play The Note 61, at velocity 94 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 59, 86); // Play The Note 59, at velocity 86 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 97); // Play The Note 40, at velocity 97 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 104); // Play The Note 40, at velocity 104 on channel 4
      player.noteOn(5, 56, 97); // Play The Note 56, at velocity 97 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 104); // Play The Note 38, at velocity 104 on channel 4
      player.noteOn(5, 54, 97); // Play The Note 54, at velocity 97 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(135); // Wait For The Next Note
      player.noteOn(9, 59, 89); // Play The Note 59, at velocity 89 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 98); // Play The Note 40, at velocity 98 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 97); // Play The Note 40, at velocity 97 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 107); // Play The Note 38, at velocity 107 on channel 4
      player.noteOn(5, 54, 95); // Play The Note 54, at velocity 95 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 103); // Play The Note 38, at velocity 103 on channel 4
      player.noteOn(5, 54, 95); // Play The Note 54, at velocity 95 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 103); // Play The Note 42, at velocity 103 on channel 4
      player.noteOn(5, 57, 95); // Play The Note 57, at velocity 95 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      player.noteOff(5, 57); // Turn off Note 57, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 106); // Play The Note 42, at velocity 106 on channel 4
      player.noteOn(5, 57, 95); // Play The Note 57, at velocity 95 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 57); // Turn off Note 57, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 110); // Play The Note 38, at velocity 110 on channel 4
      player.noteOn(5, 54, 98); // Play The Note 54, at velocity 98 on channel 5
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 59, 110); // Play The Note 59, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 105); // Play The Note 32, at velocity 105 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      player.noteOn(9, 59, 112); // Play The Note 59, at velocity 112 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 98); // Play The Note 32, at velocity 98 on channel 4
      player.noteOn(5, 59, 95); // Play The Note 59, at velocity 95 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 113); // Play The Note 30, at velocity 113 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 59, 92); // Play The Note 59, at velocity 92 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 59, 104); // Play The Note 59, at velocity 104 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 59, 98); // Play The Note 59, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 102); // Play The Note 30, at velocity 102 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 76); // Play The Note 53, at velocity 76 on channel 3
      player.noteOn(4, 34, 115); // Play The Note 34, at velocity 115 on channel 4
      player.noteOn(5, 61, 98); // Play The Note 61, at velocity 98 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 59, 112); // Play The Note 59, at velocity 112 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 59); // Turn off Note 59, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      Thread.Sleep(208); // Wait For The Next Note
      player.noteOn(9, 51, 71); // Play The Note 51, at velocity 71 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(9, 51, 77); // Play The Note 51, at velocity 77 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(229); // Wait For The Next Note
      player.noteOn(9, 51, 95); // Play The Note 51, at velocity 95 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(218); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 103); // Play The Note 40, at velocity 103 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      player.noteOn(9, 51, 98); // Play The Note 51, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 96); // Play The Note 40, at velocity 96 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 105); // Play The Note 38, at velocity 105 on channel 4
      player.noteOn(5, 54, 98); // Play The Note 54, at velocity 98 on channel 5
      player.noteOn(9, 40, 104); // Play The Note 40, at velocity 104 on channel 9
      player.noteOn(9, 51, 89); // Play The Note 51, at velocity 89 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(9, 51, 89); // Play The Note 51, at velocity 89 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 103); // Play The Note 40, at velocity 103 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      player.noteOn(9, 51, 89); // Play The Note 51, at velocity 89 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 99); // Play The Note 40, at velocity 99 on channel 4
      player.noteOn(5, 56, 95); // Play The Note 56, at velocity 95 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 107); // Play The Note 38, at velocity 107 on channel 4
      player.noteOn(5, 54, 95); // Play The Note 54, at velocity 95 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 51, 83); // Play The Note 51, at velocity 83 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 51, 95); // Play The Note 51, at velocity 95 on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 98); // Play The Note 38, at velocity 98 on channel 4
      player.noteOn(5, 54, 95); // Play The Note 54, at velocity 95 on channel 5
      player.noteOn(9, 36, 98); // Play The Note 36, at velocity 98 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 103); // Play The Note 42, at velocity 103 on channel 4
      player.noteOn(5, 57, 96); // Play The Note 57, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      player.noteOn(9, 51, 89); // Play The Note 51, at velocity 89 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 57); // Turn off Note 57, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 101); // Play The Note 42, at velocity 101 on channel 4
      player.noteOn(5, 57, 96); // Play The Note 57, at velocity 96 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(5, 57); // Turn off Note 57, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 110); // Play The Note 38, at velocity 110 on channel 4
      player.noteOn(5, 54, 98); // Play The Note 54, at velocity 98 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 77); // Play The Note 51, at velocity 77 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(114); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 104); // Play The Note 32, at velocity 104 on channel 4
      player.noteOn(5, 59, 95); // Play The Note 59, at velocity 95 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      player.noteOn(9, 51, 83); // Play The Note 51, at velocity 83 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 96); // Play The Note 32, at velocity 96 on channel 4
      player.noteOn(5, 59, 94); // Play The Note 59, at velocity 94 on channel 5
      player.noteOn(9, 36, 104); // Play The Note 36, at velocity 104 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 104); // Play The Note 30, at velocity 104 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 51, 95); // Play The Note 51, at velocity 95 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(166); // Wait For The Next Note
      player.noteOn(9, 51, 86); // Play The Note 51, at velocity 86 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 110); // Play The Note 32, at velocity 110 on channel 4
      player.noteOn(5, 59, 95); // Play The Note 59, at velocity 95 on channel 5
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(9, 51, 83); // Play The Note 51, at velocity 83 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 98); // Play The Note 32, at velocity 98 on channel 4
      player.noteOn(5, 59, 94); // Play The Note 59, at velocity 94 on channel 5
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 112); // Play The Note 30, at velocity 112 on channel 4
      player.noteOn(5, 58, 97); // Play The Note 58, at velocity 97 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 51, 101); // Play The Note 51, at velocity 101 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(145); // Wait For The Next Note
      player.noteOn(9, 51, 95); // Play The Note 51, at velocity 95 on channel 9
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 107); // Play The Note 30, at velocity 107 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 76); // Play The Note 53, at velocity 76 on channel 3
      player.noteOn(4, 34, 106); // Play The Note 34, at velocity 106 on channel 4
      player.noteOn(5, 61, 95); // Play The Note 61, at velocity 95 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 51, 101); // Play The Note 51, at velocity 101 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 76); // Play The Note 53, at velocity 76 on channel 3
      player.noteOn(4, 34, 106); // Play The Note 34, at velocity 106 on channel 4
      player.noteOn(5, 61, 98); // Play The Note 61, at velocity 98 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 112); // Play The Note 30, at velocity 112 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 51, 98); // Play The Note 51, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 103); // Play The Note 40, at velocity 103 on channel 4
      player.noteOn(5, 56, 94); // Play The Note 56, at velocity 94 on channel 5
      player.noteOn(9, 36, 126); // Play The Note 36, at velocity 126 on channel 9
      player.noteOn(9, 53, 80); // Play The Note 53, at velocity 80 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 100); // Play The Note 40, at velocity 100 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 107); // Play The Note 38, at velocity 107 on channel 4
      player.noteOn(5, 54, 96); // Play The Note 54, at velocity 96 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 53, 92); // Play The Note 53, at velocity 92 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(93); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 53, 74); // Play The Note 53, at velocity 74 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 106); // Play The Note 40, at velocity 106 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(9, 53, 86); // Play The Note 53, at velocity 86 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 52, 84); // Play The Note 52, at velocity 84 on channel 2
      player.noteOn(3, 47, 82); // Play The Note 47, at velocity 82 on channel 3
      player.noteOn(4, 40, 102); // Play The Note 40, at velocity 102 on channel 4
      player.noteOn(5, 56, 96); // Play The Note 56, at velocity 96 on channel 5
      player.noteOn(9, 36, 112); // Play The Note 36, at velocity 112 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(5, 56); // Turn off Note 56, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 40); // Turn off Note 40, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 52); // Turn off Note 52, on channel 2
      player.noteOff(3, 47); // Turn off Note 47, on channel 3
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 105); // Play The Note 38, at velocity 105 on channel 4
      player.noteOn(5, 54, 96); // Play The Note 54, at velocity 96 on channel 5
      player.noteOn(9, 40, 114); // Play The Note 40, at velocity 114 on channel 9
      player.noteOn(9, 53, 77); // Play The Note 53, at velocity 77 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 53, 80); // Play The Note 53, at velocity 80 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 96); // Play The Note 38, at velocity 96 on channel 4
      player.noteOn(5, 54, 97); // Play The Note 54, at velocity 97 on channel 5
      player.noteOn(9, 36, 110); // Play The Note 36, at velocity 110 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 106); // Play The Note 42, at velocity 106 on channel 4
      player.noteOn(5, 57, 96); // Play The Note 57, at velocity 96 on channel 5
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 53, 74); // Play The Note 53, at velocity 74 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      player.noteOff(5, 57); // Turn off Note 57, on channel 5
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 42, 103); // Play The Note 42, at velocity 103 on channel 4
      player.noteOn(5, 57, 93); // Play The Note 57, at velocity 93 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 57); // Turn off Note 57, on channel 5
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 42); // Turn off Note 42, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 50, 84); // Play The Note 50, at velocity 84 on channel 2
      player.noteOn(3, 45, 82); // Play The Note 45, at velocity 82 on channel 3
      player.noteOn(4, 38, 105); // Play The Note 38, at velocity 105 on channel 4
      player.noteOn(5, 54, 98); // Play The Note 54, at velocity 98 on channel 5
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      player.noteOn(9, 53, 83); // Play The Note 53, at velocity 83 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 54); // Turn off Note 54, on channel 5
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(4, 38); // Turn off Note 38, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 50); // Turn off Note 50, on channel 2
      player.noteOff(3, 45); // Turn off Note 45, on channel 3
      Thread.Sleep(156); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 107); // Play The Note 32, at velocity 107 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      player.noteOn(9, 53, 98); // Play The Note 53, at velocity 98 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 110); // Play The Note 32, at velocity 110 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 111); // Play The Note 30, at velocity 111 on channel 4
      player.noteOn(5, 58, 95); // Play The Note 58, at velocity 95 on channel 5
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 53, 83); // Play The Note 53, at velocity 83 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 53, 101); // Play The Note 53, at velocity 101 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOn(2, 56, 84); // Play The Note 56, at velocity 84 on channel 2
      player.noteOn(3, 51, 82); // Play The Note 51, at velocity 82 on channel 3
      player.noteOn(4, 32, 111); // Play The Note 32, at velocity 111 on channel 4
      player.noteOn(5, 59, 96); // Play The Note 59, at velocity 96 on channel 5
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(72); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(10); // Wait For The Next Note
      player.noteOff(5, 59); // Turn off Note 59, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 32); // Turn off Note 32, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 56); // Turn off Note 56, on channel 2
      player.noteOff(3, 51); // Turn off Note 51, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 53, 98); // Play The Note 53, at velocity 98 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(2, 54, 84); // Play The Note 54, at velocity 84 on channel 2
      player.noteOn(3, 49, 82); // Play The Note 49, at velocity 82 on channel 3
      player.noteOn(4, 30, 103); // Play The Note 30, at velocity 103 on channel 4
      player.noteOn(5, 58, 96); // Play The Note 58, at velocity 96 on channel 5
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 58); // Turn off Note 58, on channel 5
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(4, 30); // Turn off Note 30, on channel 4
      Thread.Sleep(31); // Wait For The Next Note
      player.noteOff(2, 54); // Turn off Note 54, on channel 2
      player.noteOff(3, 49); // Turn off Note 49, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(2, 58, 84); // Play The Note 58, at velocity 84 on channel 2
      player.noteOn(3, 53, 82); // Play The Note 53, at velocity 82 on channel 3
      player.noteOn(4, 34, 115); // Play The Note 34, at velocity 115 on channel 4
      player.noteOn(5, 61, 98); // Play The Note 61, at velocity 98 on channel 5
      player.noteOn(9, 40, 127); // Play The Note 40, at velocity 127 on channel 9
      player.noteOn(9, 53, 101); // Play The Note 53, at velocity 101 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(5, 61); // Turn off Note 61, on channel 5
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 58); // Turn off Note 58, on channel 2
      player.noteOff(3, 53); // Turn off Note 53, on channel 3
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(4, 34); // Turn off Note 34, on channel 4
      Thread.Sleep(687); // Wait For The Next Note
      player.noteOn(9, 36, 114); // Play The Note 36, at velocity 114 on channel 9
      Thread.Sleep(52); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(9, 40, 124); // Play The Note 40, at velocity 124 on channel 9
      Thread.Sleep(322); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Doom(player);
    }
    #endregion
  }
}
