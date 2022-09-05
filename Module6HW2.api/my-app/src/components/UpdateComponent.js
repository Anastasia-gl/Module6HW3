import React from "react";

class Update extends React.Component{   
    render(){
        return(
            <div>
            <h3>Update Product</h3>
            <form  onSubmit={this.props.updateMethod}>
            <input type="text" name="id" placeholder="id"/>
            <input type="text" name="title" placeholder="title"/>
            <input type="text" name="price" placeholder="price"/>
            <input type="text" name="photoURL" placeholder="photoURL"/>
            <input type="text" name="description" placeholder="description"/>
            <button>UPDATE</button>
           </form>
            </div>
        );
    }  
}

export default Update;