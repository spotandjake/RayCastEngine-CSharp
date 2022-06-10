using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using WebSocketSharp;


namespace RayCastEngine.GameComponents {
  // Network Spec Information
  enum PacketId {
    Auth = 1,
    ChatMessage = 2,
    PlayerPosition = 3
  }
  // Network Controller
  class Network {
    // Properties
    private string serverURL;
    private string username;
    private WebSocket connection;
    // Setup
    public Network(string serverURL, string username) {
      // Set Properties
      this.serverURL = serverURL;
      this.username = username;
      // Conenctr To Server
      WebSocket ws = new WebSocket(serverURL);
      this.connection = ws;
      // Set Listener
      ws.OnMessage += (sender, e) => {
        Console.WriteLine("Server: " + e.Data);
      };
      ws.OnError += (sender, e) => {
        Console.WriteLine("Server Closed");
      };
      // Connect
      ws.Connect();
      // Authenticate
      try {
        sendAuthPackage();
      } catch (Exception) { }
    }
    // Message Creators
    private void sendAuthPackage () {
      // Build The Auth Package
      byte[] package = createMessage(PacketId.Auth, encodeString(this.username));
      // Send The Package
      this.connection.Send(package);
    }
    public void sendPositionPackage(Vector3 position, Vector3 direction) {
      // TODO: Handle Floats On Both Sides
      // Build Packet
      byte[] usernamePackage = encodeString(this.username);
      byte[] xPackage = encodeFloat(position.X);
      byte[] yPackage = encodeFloat(position.Y);
      byte[] zPackage = encodeFloat(position.Z);
      byte[] dirXPackage = encodeFloat(direction.X);
      byte[] dirYPackage = encodeFloat(direction.Y);
      byte[] pitchPackage = encodeFloat(direction.Z);
      // Combine Packet
      byte[] packageContents = usernamePackage.Concat(xPackage).Concat(yPackage).Concat(zPackage).Concat(dirXPackage).Concat(dirYPackage).Concat(pitchPackage).ToArray();
      byte[] package = createMessage(PacketId.PlayerPosition, packageContents);
      // Send Packet
      this.connection.Send(package);
    }
    // Encoding Helpers
    // Create message
    private byte[] createMessage(PacketId header, byte[] value) {
      // Return Concatted Data
      return encodeInt((int)header).Concat(value).ToArray();
    }
    // Handle String Encoding
    private byte[] encodeString(string value) {
      byte[] stringBytes = Encoding.ASCII.GetBytes(value);
      byte[] bytes = encodeInt(stringBytes.Length);
      return bytes.Concat(stringBytes).ToArray();
    }
    // Handle Number Encoding
    private byte[] encodeInt(int value) {
      byte[] bytes = new byte[4];
      bytes[0] = (byte)(value >> 24);
      bytes[1] = (byte)(value >> 16);
      bytes[2] = (byte)(value >> 8);
      bytes[3] = (byte)value;
      return bytes;
    }
    // Handle Float Encoding
    private byte[] encodeFloat(float value) {
      byte[] bytes = BitConverter.GetBytes(value);
      if (BitConverter.IsLittleEndian)
        Array.Reverse(bytes);
      return bytes;
    }
  }
}