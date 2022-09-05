import Update from "./components/UpdateComponent";
import React, { useState } from "react";
import Get from './components/GetComponent'
import Post from "./components/PostComponent";
import Delete from "./components/DeleteComponent";

class App extends React.Component{

  //UPDATE

  update = async(e) =>{
    e.preventDefault();
    var response = await fetch(`https://localhost:7029/Product`, {
      method: 'PUT',
      headers: {
          'Content-Type': 'application/json',
      },
      body: JSON.stringify({
          id:e.target.elements.id.value,
          title: e.target.elements.title.value,
          price: e.target.elements.price.value,
          photoURL: e.target.elements.photoURL.value,
          description: e.target.elements.description.value,
      })});
  }

  //DELETE

  delete = async(e) =>{
    e.preventDefault();
    const id = e.target.elements.id.value;
    var response = await fetch(`https://localhost:7029/Product/${id}`, {
      method: 'DELETE',
      headers: {
          'Content-Type': 'application/json',
      }});
  }

  //POST

  post = async(e) =>{
    e.preventDefault();
    var response = await fetch('https://localhost:7029/Product', {
      method: 'POST',
      headers: {
          'Content-Type': 'application/json',
      },
      body: JSON.stringify({
          title: e.target.elements.title.value,
          price: e.target.elements.price.value,
          photoURL: e.target.elements.photoURL.value,
          description: e.target.elements.description.value,
      })});
  }

  //GET

  get = async (e) =>{
    e.preventDefault();
    const id = e.target.elements.id.value;
    const url =  await fetch(`https://localhost:7029/Product/${id}`);
    const data = await url.json();
    console.log(data);
  }

  render(){
    return(
  <>
  <Get getMethod={this.get}/> 
  <Post postMethod={this.post}/>
  <Delete deleteMethod={this.delete}/>
  <Update updateMethod={this.update}/>
  </>
    );
  }
}

export default App;
