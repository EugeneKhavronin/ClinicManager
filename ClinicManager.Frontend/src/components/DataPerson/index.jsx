import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Grid from '@material-ui/core/Grid';
import Typography from '@material-ui/core/Typography';
import ButtonBase from '@material-ui/core/ButtonBase';

const useStyles = makeStyles(theme => ({
  root: {
    flexGrow: 1,
    marginLeft: 30,
    marginTop: 30
  },
  paper: {
    padding: theme.spacing(2),
    margin: 'auto',
    maxWidth: 500
  },
  image: {
    width: 128,
    height: 128
  },
  img: {
    margin: 'auto',
    display: 'block',
    maxWidth: '100%',
    maxHeight: '100%'
  }
}));

export default function ComplexGrid() {
  const classes = useStyles();

  return (
    <div className={classes.root}>
      <Grid container spacing={2}>
        <Grid item>
          <ButtonBase className={classes.image}>
            <img
              className={classes.img}
              alt="complex"
              src="http://vnuki.by/images/RTvr231qD9j3hN5LJ0khvBbXUNZqTOvhnuQ53YOK5yVWpTazi6.jpg"
            />
          </ButtonBase>
        </Grid>
        <Grid item xs={12} sm container>
          <Grid item xs container direction="column" spacing={2}>
            <Grid item xs>
              <Typography gutterBottom variant="subtitle1">
                Фамилия: Сорокин
              </Typography>
              <Typography gutterBottom variant="subtitle1">
                Имя: Евгений
              </Typography>
              <Typography gutterBottom variant="subtitle1">
                Фамилия: Александрович
              </Typography>
              <Typography variant="body2" gutterBottom>
                Телефон: 81234567850
              </Typography>
              <Typography variant="body2" gutterBottom>
                Телефон: 81234567850
              </Typography>
              <Typography variant="body2" color="textSecondary">
                Дата рождения: 11.11.1111
              </Typography>
            </Grid>
          </Grid>
        </Grid>
      </Grid>
    </div>
  );
}
