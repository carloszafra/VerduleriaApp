import React, { Component } from 'react';

export class ProductList extends Component {
  static displayName = ProductList.name;
  type = "";
  constructor(props) {
    super(props);
    this.state = { products: [], loading: true };
    this.type = props.type;
  }

  componentDidMount() {
    this.populateProductData();
  }

  static renderProductsTable(products) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Id</th>
            <th>Nombre</th>
            <th>Descripción</th>
            <th>Precio</th>
            <th>Inventario</th>
          </tr>
        </thead>
        <tbody>
          {products.map(product =>
            <tr key={product.id}>
              <td>{product.id}</td>
              <td>{product.name}</td>
              <td>{product.description}</td>
              <td>{product.price}</td>
              <td>{product.stock}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : ProductList.renderProductsTable(this.state.products);

    return (
      <div>
        <h1 id="tabelLabel" >{this.type==="vegetal" ? "Vegetales":"Frutas"}</h1>
        <p>Una lista</p>
        {contents}
      </div>
    );
  }

  async populateProductData() {
    const response = await fetch(`api/products/${this.type}`);
    console.log(response)
    console.log(this.type);
    const resp = await response.json();
    console.log(resp.data);
    this.setState({ products: resp.data, loading: false });
  }
}


