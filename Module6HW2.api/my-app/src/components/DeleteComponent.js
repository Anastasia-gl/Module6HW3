import React from "react";

class Delete extends React.Component{   
    render(){
        return(
            <div>
            <h3>Delete Product</h3>
            <form  onSubmit={this.props.deleteMethod}>
             <input type="text" name="id" placeholder="ID"/>
             <button>DELETE</button>
           </form>
            </div>
        );
    }  
}

export default Delete;