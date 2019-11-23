import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import Paper from '@material-ui/core/Paper';

const useStyles = makeStyles({
  root: {
    width: '100%',
    overflowX: 'auto',
    marginRight: 15,
    marginTop: 15,
    height: 320
  },
  table: {
    minWidth: 650
  }
});

function createData(name, calories, fat, carbs, protein, number) {
  return { name, calories, fat, carbs, protein, number };
}

const rows = [
  createData(
    'Здоровье семьи',
    '10.04.12',
    'лор',
    'Иванов И. И.',
    '1200 р',
    120
  ),
  createData(
    'Клиническая больница №8',
    '05.01.16',
    'терапевт',
    'Петров М. П.',
    '-',
    360
  ),
  createData(
    'Клиническая больница №8',
    '21.08.16',
    'хирург',
    'Игнатова А. А.',
    '-',
    502
  ),
  createData('Кедр', '19.06.18', 'окулист', 'Смирнов П. Л.', '600 р', 12),
  createData(
    'Ниар-медик',
    '01.09.19',
    'ревматолог',
    'Сергеев П. П.',
    '1800 р',
    34
  )
];

export default function SimpleTable() {
  const classes = useStyles();

  return (
    <Paper className={classes.root}>
      <Table className={classes.table} aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell>Название клиники</TableCell>
            <TableCell align="right">Дата посещения</TableCell>
            <TableCell align="right">Специализация врача</TableCell>
            <TableCell align="right">ФИО врача</TableCell>
            <TableCell align="right">Стоимость приёма</TableCell>
            <TableCell align="right">Номер кабинета</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {rows.map(row => (
            <TableRow key={row.name}>
              <TableCell component="th" scope="row">
                {row.name}
              </TableCell>
              <TableCell align="right">{row.calories}</TableCell>
              <TableCell align="right">{row.fat}</TableCell>
              <TableCell align="right">{row.carbs}</TableCell>
              <TableCell align="right">{row.protein}</TableCell>
              <TableCell align="right">{row.number}</TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </Paper>
  );
}
