import React from "react";

class Get extends React.Component{   
    render(){
        return(
            <div>
            <h3>Get Product By ID</h3>
            <form  onSubmit={this.props.getMethod}>
             <input type="text" name="id" placeholder="ID"/>
             <button>GET</button>
           </form>
            </div>
        );
    }  
}

export default Get;