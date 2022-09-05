import React from "react";

class Post extends React.Component{   
    render(){
        return(
            <div>
            <h3>Post Product</h3>
            <form  onSubmit={this.props.postMethod}>
            <input type="text" name="title" placeholder="title"/>
            <input type="text" name="price" placeholder="price"/>
            <input type="text" name="photoURL" placeholder="photoURL"/>
            <input type="text" name="description" placeholder="description"/>
            <button>POST</button>
           </form>
            </div>
        );
    }  
}

export default Post;