import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Item } from './components/Item';
import { ItemStatistic } from './components/ItemStatistic';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
       <Route path='/item' component={Item} />
       <Route path='/statistic' component={ItemStatistic} /> 
       </Layout>
    );
  }
}
