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
      // Connect To Server
      using (WebSocket ws = new WebSocket(serverURL)) {
        // Set Conenction
        this.connection = ws;
        // Set Listener
        ws.OnMessage += (sender, e) => {
          Console.WriteLine("Server: " + e.Data);
        };
        // Connect
        ws.Connect();
        // Authenticate
        sendAuthPackage();
      }
    }
    // Message Creators
    private void sendAuthPackage () {
      // Build The Auth Package
      byte[] package = createMessage(PacketId.Auth, encodeString(this.username));
      // Send The Package
      this.connection.Send(package);
    }
    private void sendPositionPackage(Vector3 position, Vector3 direction) {
      // TODO: Handle Floats On Both Sides
      // Build Packet
      byte[] usernamePackage = encodeString(this.username);
      byte[] xPackage = encodeInt((int)position.X);
      byte[] yPackage = encodeInt((int)position.X);
      byte[] zPackage = encodeInt((int)position.X);
      byte[] dirXPackage = encodeInt((int)direction.X);
      byte[] dirYPackage = encodeInt((int)direction.Y);
      byte[] pitchPackage = encodeInt((int)direction.Z);
      // Combine Packet
      byte[] packageContents = usernamePackage.Concat(xPackage).Concat(yPackage).Concat(zPackage).Concat(dirXPackage).Concat(dirYPackage).Concat(pitchPackage).ToArray();
      byte[] package = createMessage(PacketId.ChatMessage, packageContents);
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
      byte[] bytes = new byte[4];
      bytes[0] = (byte)(stringBytes.Length >> 24);
      bytes[1] = (byte)(stringBytes.Length >> 16);
      bytes[2] = (byte)(stringBytes.Length >> 8);
      bytes[3] = (byte)stringBytes.Length;
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
  }
}