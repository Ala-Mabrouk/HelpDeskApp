


var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();





//Disable send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (mail, name, thumbUrl, message) {


    var html = '';
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var div = document.createElement("div");
    var loged = document.getElementById("logedUser").value;
    //test on user so we can know how to display response 

    //if me 
    if (mail == loged) {

        html = ' <div class="sent_msg"> <p>' + msg + '</p> </div>'


        div.className = "outgoing_msg";

    }
    else {

        html = '<div class="incoming_msg_img" > <img src="C:/Users/worrior107/source/repos/HelpDeskApp/HelpDesk/wwwroot/Content/images/123-re.png" alt="' + name + '"></div><div class="received_msg"><div class="received_withd_msg"><p>' + msg + '</p></div></div>';

        div.className = "incoming_msg";
    }

    div.innerHTML = html;

    document.getElementById("messagesList").appendChild(div);

});







connection.start().then(function () {
    connection.invoke("GetConnectionId").then(function (id) {
      //  document.getElementById("connectionId").innerText = id;

    });
    //  document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


document.getElementById("sendToUser").addEventListener("click", function (event) {


    var message = document.getElementById("messageInput").value;

    var sender = document.getElementById("logedUser").value;
    var reciver = document.getElementById("reciverUser").value;

    console.log(sender);
    console.log(reciver);

    //*********** get my message in html *******************

    var html = '';
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var div = document.createElement("div");
    html = ' <div class="sent_msg"> <p>' + msg + '</p> </div>'


    div.className = "outgoing_msg";

    div.innerHTML = html;

    document.getElementById("messagesList").appendChild(div);

    //******************************************************

    document.getElementById("messageInput").value = "";



    connection.invoke("SendToUser", sender, reciver, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

























/*document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
*/



















/*document.getElementById("sendToGroup").addEventListener("click", function (event) {
    var sender = document.getElementById("userInput").value;
    var receiver = document.getElementById("receiverId").value;
    var connsenderID = document.getElementById("connectionId").value;
    console.log(receiver);
    console.log(sender);
    console.log(receiver);

    var message = document.getElementById("messageInput").value;

    if (receiver != "") {

        connection.invoke("SendMessageToGroup", sender, connsenderID, receiver, message).catch(function (err) {
            return console.error(err.toString());
        });
    }
    *//*  else {
  connection.invoke("SendMessage", sender, message).catch(function (err) {
      return console.error(err.toString());
  });
}*//*
event.preventDefault();
});*/