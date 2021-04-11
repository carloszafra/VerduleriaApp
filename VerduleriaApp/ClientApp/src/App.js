import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { ProductList } from './components/ProductList';
import { Counter } from './components/Counter';
import 'bootstrap/dist/css/bootstrap.min.css';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/frutas'>
          <ProductList type={"fruta"}/>
        </Route>
        <Route path='/vegetales'>
          <ProductList type={"vegetal"}/>
        </Route>
      </Layout>
    );
  }
}
